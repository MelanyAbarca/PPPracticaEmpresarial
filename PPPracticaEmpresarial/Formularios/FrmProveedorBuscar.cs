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
    public partial class FrmProveedorBuscar : Form
    {
        // Objetos locales 
        DataTable DtLista { get; set; }
        Proveedor MiProveedorLocal { get; set; }

        public FrmProveedorBuscar()
        {
            InitializeComponent();
            DtLista = new DataTable();
            // Para el almacenamiento de una consulta en una fila
            MiProveedorLocal = new Proveedor();
        }

        private void FrmProveedorBuscar_Load(object sender, EventArgs e)
        {
            LlenarLista();
        }

        private void LlenarLista()
        {
            DtLista = new DataTable();

            DtLista = MiProveedorLocal.Listar(true, TxtBuscar.Text.Trim());

            DgvLista.DataSource = DtLista;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscar.Text.Count() > 2 || string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                LlenarLista();
            }
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (DgvLista.SelectedRows.Count == 1)
            {
                DataGridViewRow row = DgvLista.SelectedRows[0];

                int IdProveedor = Convert.ToInt32(row.Cells["CProveedorID"].Value);
                string NombreProveedor = Convert.ToString(row.Cells["CProveedorNombre"].Value);

                //Pasar las variables al objeto de compra del formulario de registro de los productos.

                Globales.MiFormGestionProductos.MiCompraLocal.MiProveedor.ProveedorNombre = NombreProveedor;
                Globales.MiFormGestionProductos.MiCompraLocal.MiProveedor.ProveedorID = IdProveedor;
                DialogResult = DialogResult.OK;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
