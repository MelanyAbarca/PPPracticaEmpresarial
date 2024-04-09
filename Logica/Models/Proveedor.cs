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
    public class Proveedor
    {
        // Propiedades simples
        public int ProveedorID { get; set; }
        public string ProveedorNombre { get; set; }

        public string ProveedorCedula { get; set; }

        public string ProveedorEmail { get; set; }

        public string ProveedorDireccion { get; set; }

        public string ProveedorNotas { get; set; }

        public bool Activo { get; set; }

        public TipoProveedor MiTipoProveedor { get; set; }

        // Propiedades Compuestas

        public Proveedor()
        {
            MiTipoProveedor = new TipoProveedor();
        }

        // Funciones y Metodos
        public bool Agregar()
        {

            bool R = false;

            // Codigo funcional que invoca a un  procedimiento almacenado que contiene el DML Insert

            Conexion MiCnn = new Conexion();

            //Agregar Parametros
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.ProveedorEmail));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.ProveedorNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.ProveedorCedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.ProveedorDireccion));

            //Extraccion del fk que se debe extraer del valor del objeto compuesto "Tipo proveedor"

            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdTipoProveedor", this.MiTipoProveedor.ProveedorTipoDescripcion));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPProveedorAgregar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }
        // Consulta del proveedor por medio del correo
        public bool ConsultarPorEmail()
        {
            bool R = false;


            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.ProveedorEmail));

            DataTable consulta = new DataTable();

            consulta = MiCnn.EjecutarSELECT("SPProveedorConsultarPorEmail");


            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProveedorID));

            // Necesito un datatable para capturar la info proveedor
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPProveedorConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;
            }

            return R;

        }

        // Consulta por medio de la cedila 
        public bool ConsultarPorCedula()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            // Paramentreo cedula agregado
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.ProveedorCedula));

            DataTable consulta = new DataTable();

            consulta = MiCnn.EjecutarSELECT("SPProveedorConsultarPorCedula");

            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }
            return R;
        }

        // Consulta del id devolviendo el proveedor
        public Proveedor ConsultarPorIDRetornaProveedor()
        {
            Proveedor R = new Proveedor();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProveedorID));


            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPProveedorConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                // Objeto dt obteniendo el index 0

                DataRow dr = dt.Rows[0];

                R.ProveedorID = Convert.ToInt32(dr["ProveedorID"]);
                R.ProveedorNombre = Convert.ToString(dr["ProveedorNombre"]);
                R.ProveedorCedula = Convert.ToString(dr["ProveedorCedula"]);
                R.ProveedorEmail = Convert.ToString(dr["ProveedorCorreo"]);
                R.ProveedorDireccion = Convert.ToString(dr["ProveedoroDireccion"]);

                //Composiciones 

                R.MiTipoProveedor.ProveedorTipoDescripcion = Convert.ToString(dr["ProveedorTipoID"]);
                R.MiTipoProveedor.ProveedorTipoDescripcion = Convert.ToString(dr["ProveedorTipoDescripcion"]);

            }


            return R;

        }
        public DataTable Listar(bool verActivos = true, string FiltroBusqueda = "")
        {
            DataTable R = new DataTable();

            // Codigo para llamar a una operacion listar en un procedimiento almacenado 

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", verActivos));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", FiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPProveedorListar");

            return R;
        }

        public DataTable ListarActivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPProveedorListar");
            return R;
        }

        public DataTable ListarInactivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPProveedoresListar");



            return R;
        }
    }
}
