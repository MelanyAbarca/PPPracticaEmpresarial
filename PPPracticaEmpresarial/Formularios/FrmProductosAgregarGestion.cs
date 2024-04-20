using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPracticaEmpresarial.Formularios
{
    public partial class FrmProductosAgregarGestion : Form
    {
        // Objeto Local
        private Logica.Models.Producto MiProductoLocal { get; set; }

        // Lista local de DgvList
        private DataTable ListaProductos { get; set; }
        public FrmProductosAgregarGestion()
        {
            InitializeComponent();
            MiProductoLocal = new Logica.Models.Producto();
            ListaProductos = new DataTable();
        }

        private void FrmProductosAgregarGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;

            CargarListaCategoriasProducto();

            CargarListaDeProductos();
        }

        private void CargarListaDeProductos()
        {
            // Resetear la lista de los productos haciendo re instancia del objeto

            ListaProductos = new DataTable();

            //En caso de que en el cuadro haya 2 o mas crateres se filtra la lista

            string FiltroBusqueda = "";
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {
                FiltroBusqueda = TxtBuscar.Text.Trim();
            }


            if (CboxVerActivos.Checked)
            {
                ListaProductos = MiProductoLocal.ListarActivos(FiltroBusqueda);
            }
            else
            {
                ListaProductos = MiProductoLocal.ListarInactivos(FiltroBusqueda);
            }

            DgvLista.DataSource = ListaProductos;
        }

        private void CargarListaCategoriasProducto()
        {

            Logica.Models.CategoriaProducto MiCategoria = new Logica.Models.CategoriaProducto();
            DataTable dt = new DataTable();
            dt = MiCategoria.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {

                CbCategoriasProductos.ValueMember = "ID";
                CbCategoriasProductos.DisplayMember = "Descrip";
                CbCategoriasProductos.DataSource = dt;
                CbCategoriasProductos.SelectedIndex = -1;

            }
        }

        private void DgvLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvLista.ClearSelection();
        }

        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarEditarEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void DgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvLista.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                // Seleccion de la primera fila (Indice 0)
                DataGridViewRow MiFila = DgvLista.SelectedRows[0];


                // Lo que necesito es el valor del ID del producto para realizar la 
                //consulta y traer todo los datos para llenar el objeto de producto local

                int IdProducto = Convert.ToInt32(MiFila.Cells["CProductoID"].Value);

                // Para no asumir riesgos se reinstancia el Productolocal
                MiProductoLocal = new Logica.Models.Producto();


                //Ahora le agregamos el valor obtenido por la fila ID del usuario local
                MiProductoLocal.ProductoID = IdProducto;

                //Una vez que tengo el objeto local con el valor del ID, puedo ir a consultar
                //el usuario por ese id y llenar el resto de atributos.

                MiProductoLocal = MiProductoLocal.ConsultarPorIDRetornaProducto();

                // Validamos que el usuario local tenga datos 

                if (MiProductoLocal != null && MiProductoLocal.ProductoID > 0)
                {

                    // Si lo cargamos correctamente el usuario local llenamos los
                    // controles

                    TxtProductoID.Text = Convert.ToString(MiProductoLocal.ProductoID);
                    TxtProductoCodigoBarras.Text = MiProductoLocal.ProductoCodigoBarras;
                    TxtProductoNombre.Text = MiProductoLocal.ProductoNombre;
                    TxtCantidadStock.Text = Convert.ToString(MiProductoLocal.CantidadStock);
                    TxtProductoCostoUnitario.Text = Convert.ToString(MiProductoLocal.CostoUnitario);
                    TxtProductoPrecioVentaUnitario.Text = Convert.ToString(MiProductoLocal.PrecioVentaUnitario);

                    // Combobox
                    CbCategoriasProductos.SelectedValue = MiProductoLocal.MiCategoria.CategoriaID;
                }
            }
        }

        private void LimpiarFormulario()
        {
            TxtProductoID.Clear();
            TxtProductoCodigoBarras.Clear();
            TxtProductoNombre.Clear();
            TxtCantidadStock.Clear();
            TxtProductoCostoUnitario.Clear();
            TxtProductoPrecioVentaUnitario.Clear();

            CbCategoriasProductos.SelectedIndex = -1;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            DgvLista.ClearSelection();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CboxVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarListaDeProductos();
            if (CboxVerActivos.Checked)
            {
                BtnEliminar.Text = "Eliminar";
            }
            else
            {
                BtnEliminar.Text = "Activar";
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiProductoLocal.ProductoID > 0 && MiProductoLocal.ConsultarProductoPorID())
            {

                if (CboxVerActivos.Checked)
                {
                    // Desactivar producto
                    DialogResult r = MessageBox.Show("Esta seguro de eliminar el producto", "??",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        if (MiProductoLocal.Eliminar())
                        {
                            MessageBox.Show("El producto ha sido eliminado correctamente",
                                             "!!", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaDeProductos();
                        }
                    }

                }
                else
                {
                    // Reactivar el producto
                    DialogResult r = MessageBox.Show("Esta seguro de activar nuevamente al usuario", "??",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        if (MiProductoLocal.Activar())
                        {
                            MessageBox.Show("El producto ha sido activado correctamente",
                                             "!!", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaDeProductos();
                        }
                    }

                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }





        // TODO LA FUNCION DE LA VALIDACION DE TODOS LOS DATOS ****



    }
}

