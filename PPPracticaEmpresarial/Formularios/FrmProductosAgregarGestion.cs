using Logica.Models;
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


                //Valor obtenido por la fila ID del producto local
                MiProductoLocal.ProductoID = IdProducto;

                //Consultar el producto por el ID

                MiProductoLocal = MiProductoLocal.ConsultarPorIDRetornaProducto();

                // Validacion de que el producto local tenga datos

                if (MiProductoLocal != null && MiProductoLocal.ProductoID > 0)
                {

                    // Si se carga el producto correctamente se procede a llenar los ddatos

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
                    DialogResult r = MessageBox.Show("Esta seguro de activar nuevamente el producto", "??",
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

        // Funcion que valida los datos 
        private bool ValidarDatosDigitados()
        {
            Boolean R = false;

            if (!string.IsNullOrEmpty(TxtProductoCodigoBarras.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProductoNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCantidadStock.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProductoCostoUnitario.Text.Trim()) &&
                 !string.IsNullOrEmpty(TxtProductoPrecioVentaUnitario.Text.Trim()) &&
                CbCategoriasProductos.SelectedIndex > -1)

            {
                R = true;
            }
            else
            {
                // Evaluacion cuando algo falta
                // Codigo Barras
                if (string.IsNullOrEmpty(TxtProductoCodigoBarras.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un ncodigo de barras para el producto", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtProductoCodigoBarras.Focus();
                    return false;
                }

                //Nombre
                if (string.IsNullOrEmpty(TxtProductoNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un nombre para el produto", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtProductoNombre.Focus();
                    return false;
                }

                //Cantidad en Stock
                if (string.IsNullOrEmpty(TxtCantidadStock.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una cantidad de items para el producto", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCantidadStock.Focus();
                    return false;
                }

                //Costo del producto unitario
                if (string.IsNullOrEmpty(TxtProductoCostoUnitario.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el costo por unidad del producto", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtProductoCostoUnitario.Focus();
                    return false;
                }

                //Precio de venta: si es el mismo del costo es por que el producto no se vende
                if (string.IsNullOrEmpty(TxtProductoPrecioVentaUnitario.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el costo por unidad del producto", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtProductoCostoUnitario.Focus();
                    return false;
                }
            }

            return R;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                // Estas variables almacenan el resultado de las consultas por codigo de barras y nombre
                bool CodigoBarrasOK;
                bool NombreOK;


                MiProductoLocal = new Logica.Models.Producto();

                // Llenar los valores de los atributos con los datos digitados en el form
                MiProductoLocal.ProductoCodigoBarras = TxtProductoCodigoBarras.Text.Trim();
                MiProductoLocal.ProductoNombre = TxtProductoNombre.Text.Trim();
                MiProductoLocal.CantidadStock = Convert.ToDecimal(TxtCantidadStock.Text.Trim());
                MiProductoLocal.CostoUnitario = Convert.ToDecimal(TxtProductoCostoUnitario.Text.Trim());
                MiProductoLocal.PrecioVentaUnitario = Convert.ToDecimal(TxtProductoPrecioVentaUnitario.Text.Trim());

                // Composicion del tipo de Producto
                MiProductoLocal.MiCategoria.CategoriaID = Convert.ToInt32(CbCategoriasProductos.SelectedValue);

                // Consultas por codigo barras / nombre del Producto
                CodigoBarrasOK = MiProductoLocal.ConsultarPorCodigoDeBarras();
                NombreOK = MiProductoLocal.ConsultarPorNombre();


                if (CodigoBarrasOK == false && NombreOK == false)
                {
                    //Si no existe ningun provedoor con esta informacion, se solicita al usuario confirmacion de si
                    //quiere agregar o no al proveedor

                    string msg = string.Format("¿Está seguro que desea agregar al productor {0}?", MiProductoLocal.ProductoNombre);
                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiProductoLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Producto agregado corectamente!", "Acción satisfactoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            LimpiarFormulario();

                            CargarListaDeProductos();
                        }
                        else
                        {
                            MessageBox.Show("El producto no se pudo agregar!", "Error al agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    // Indicar al usuario si falla alguna consulta

                    if (CodigoBarrasOK)
                    {
                        MessageBox.Show("Ya existe un producto con el codigo de barras digitado", "ERROR DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (NombreOK)
                    {
                        MessageBox.Show("Ya existe un producto con el nombre digitado", "ERROR DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }

            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {

                MiProductoLocal.ProductoCodigoBarras = TxtProductoCodigoBarras.Text.Trim();
                MiProductoLocal.ProductoNombre = TxtProductoNombre.Text.Trim();
                MiProductoLocal.CantidadStock = Convert.ToDecimal(TxtCantidadStock.Text.Trim());
                MiProductoLocal.CostoUnitario = Convert.ToDecimal(TxtProductoCostoUnitario.Text.Trim());
                MiProductoLocal.PrecioVentaUnitario = Convert.ToDecimal(TxtProductoPrecioVentaUnitario.Text.Trim());

                // Composicion del tipo de Producto: Atributo evaluado en el SP
                MiProductoLocal.MiCategoria.CategoriaID = Convert.ToInt32(CbCategoriasProductos.SelectedValue);

                // Al editar se toma en cuenta el ID

                if (MiProductoLocal.ConsultarPorID())
                {
                    DialogResult respuesta = MessageBox.Show(" Esta seguro que desea modificar el producto?", "Modificación de productos",
                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiProductoLocal.Editar())
                        {

                            MessageBox.Show("El producto ha sido modificado correctamente", "Modificación de productos",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            LimpiarFormulario();
                            CargarListaProductos();
                        }
                    }

                }

            }
        }

        private void CargarListaProductos()
        {
            // Reseteo de la lista mediante una reinstancia

            ListaProductos = new DataTable();

            // Filtro de la lista de proveedores

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
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscar.Text.Count() > 2 || string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                CargarListaProductos();
            }
        }
    }
}

