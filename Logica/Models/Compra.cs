using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Compra
    {
        // Propiedades 
        public int CompraID { get; set; }
        public DateTime CompraFecha { get; set; }
        public int CompraNumero { get; set; }
        public string CompraNotas { get; set; }
        public bool Activo { get; set; }

        // Composiciones simples 

        public Usuario MiUsuario { get; set; }
        public Proveedor MiProveedor { get; set; }
        public TipoCompra MiTipoCompra { get; set; }

        // Composiciones Compuestas

        public List<CompraDetalle> ListaDetalles { get; }

        // Ctor
        public Compra()
        {
            MiUsuario = new Usuario();
            MiProveedor = new Proveedor();
            MiTipoCompra = new TipoCompra();
            ListaDetalles = new List<CompraDetalle>();
        }

        // Funciones 

        public DataTable CargarEsquemaDetalle()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSELECT("SPCompraDetalleEsquema", true);

            // Anula la opcion del pk al cargar el esquema
            R.PrimaryKey = null;
            return R;

        }
        // Funcion de agregar en una estructura encabezado-detalle
        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            //Lista de parametros
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IDProveedor", this.MiProveedor.ProveedorID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IDTipoCompra", this.MiTipoCompra.CompraTipoID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IDUsuario", this.MiUsuario.UsuarioID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Notas", this.CompraNotas));

            Object retorno = MiCnn.EjecutarSELECTEscalar("SPCompraAgregar");

            // captura de la info mediante un scope Identity que me devuelve el "SPCompraAgregar".

            int IDCreada;

            //validacion
            if (retorno != null)
            {
                try
                {
                    IDCreada = Convert.ToInt32(retorno.ToString());

                    this.CompraID = IDCreada;

                    // Insert del detalle

                    foreach (CompraDetalle item in this.ListaDetalles)
                    {
                        Conexion MiCnnDetalle = new Conexion();

                        //Lista de parametros de SP de insert a detalle

                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@IDCompra", IDCreada));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@IDProducto", item.MiProducto.ProductoID));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@Cantidad", item.Cantidad));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@Precio", item.PrecioUnitario));

                        MiCnnDetalle.EjecutarInsertUpdateDelete("SPCompraDetalleAgregar");
                    }
                    R = true;

                }
                catch (Exception)
                {

                    throw;
                }
            }

            return R;

        }
    }
}
