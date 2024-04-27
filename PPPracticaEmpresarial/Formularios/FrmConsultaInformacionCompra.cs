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
    public partial class FrmConsultaInformacionCompra : Form
    {
        // Onjeto local de compra
        private Logica.Models.Compra MiCompraLocal { get; set; }

        //Lista local de compras que se visualizan en el datagridview

        private DataTable ListaCompras { get; set; }

        public FrmConsultaInformacionCompra()
        {
            InitializeComponent();
            MiCompraLocal = new Logica.Models.Compra();
            ListaCompras = new DataTable();
        }
        private void FrmConsultaProductos_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;
            //CargarListaRoles();

            CargarListaDeCompras();
        }

        private void CargarListaDeCompras()
        {
            // Instancia de reseteo

            ListaCompras = new DataTable();

            // Filtro de la lista de compras

            string FiltroBusqueda = "";
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {
                FiltroBusqueda = TxtBuscar.Text.Trim();
            }

            // Listar 

            ListaCompras = MiCompraLocal.ListarActivos(FiltroBusqueda);
            DgvLista.DataSource = ListaCompras;
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormGestionProductos.Visible)
            {
                Globales.MiFormGestionProductos = new FrmCompraProductosGestion();

                Globales.MiFormGestionProductos.Show();

                CargarListaDeCompras();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            DgvLista.ClearSelection();
        }
        private void LimpiarFormulario()
        {
            TxtUsuarioID.Clear();
            TxtCompraID.Clear();
            TxtProveedorID.Clear();
            TxtCompraNotas.Clear();
            TxtCompraFecha.Clear();
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarListaDeCompras();
        }
        private void DgvLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvLista.ClearSelection();
        }

        private void DgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvLista.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                DataGridViewRow MiFila = DgvLista.SelectedRows[0];

                int IdCompra = Convert.ToInt32(MiFila.Cells["CCompraID"].Value);

                // Reinstancia del usuario local
                MiCompraLocal = new Logica.Models.Compra();


                // Valor ID del usuario local
                MiCompraLocal.CompraID = IdCompra;
                MiCompraLocal = MiCompraLocal.ConsultarPorIDRetornaCompra();

                // Validamos que el usuario local tenga datos 

                if (MiCompraLocal != null && MiCompraLocal.CompraID > 0)
                {

                    // Se llena los controles 

                    TxtUsuarioID.Text = Convert.ToString(MiCompraLocal.MiUsuario.UsuarioID);
                    TxtCompraID.Text = Convert.ToString(MiCompraLocal.CompraID);
                    TxtProveedorID.Text = Convert.ToString(MiCompraLocal.MiProveedor.ProveedorID);
                    TxtCompraNotas.Text = MiCompraLocal.CompraNotas;
                    TxtCompraFecha.Text = Convert.ToString(MiCompraLocal.CompraFecha);

                }
            }
        }
    }
}
