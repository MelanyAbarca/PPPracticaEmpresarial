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
    public partial class FrmCompraAgregarProducto : Form
    {

        //VARIABLES LOCALES - Propiedades 
        DataTable ListaProductos { set; get; }
        Producto MiProductoLocal { set; get; }
        public FrmCompraAgregarProducto()
        {
            InitializeComponent();
            // Instancias 
            ListaProductos = new DataTable();
            MiProductoLocal = new Producto();
        }

        private void FrmCompraAgregarProducto_Load(object sender, EventArgs e)
        {
            LlenarLista();
        }

        private void LlenarLista()
        {
            ListaProductos = new DataTable();
            ListaProductos = MiProductoLocal.ListarEnBusqueda();

            DgvLista.DataSource = ListaProductos;
            DgvLista.ClearSelection();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            // Pasar los datos al formulario anterior 
            if (DgvLista.SelectedRows.Count == 1)
            {
                DataGridViewRow row = DgvLista.SelectedRows[0];

                // Extraccion de los valores del producto en la fila seleccionada
                int IdProducto = Convert.ToInt32(row.Cells["CProductoID"].Value);
                string NombreProducto = Convert.ToString(row.Cells["CProductoNombre"].Value);
                string CodigoBarras = Convert.ToString(row.Cells["CProductoCodigoBarras"].Value);
                decimal Precio = Convert.ToDecimal(row.Cells["CPrecioVentaUnitario"].Value);

                decimal Cantidad = NumUDCantidad.Value;

                // Nueva fila DataTable de detalle en el FrmGestionProductos y se procede con la asignacion de los valores
                DataRow MiFila = Globales.MiFormGestionProductos.ListaProductos.NewRow();

                MiFila["ProductoID"] = IdProducto;
                MiFila["Cantidad"] = Cantidad;
                MiFila["PrecioVentaUnitario"] = Precio;
                MiFila["ProductoNombre"] = NombreProducto;
                MiFila["ProductoCodigoBarras"] = CodigoBarras;

                Globales.MiFormGestionProductos.ListaProductos.Rows.Add(MiFila);

                DialogResult = DialogResult.OK;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
