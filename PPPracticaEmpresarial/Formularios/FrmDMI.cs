using CrystalDecisions.CrystalReports.Engine;
using PPPracticaEmpresarial.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.Models;

namespace PPPracticaEmpresarial.Formularios
{
    public partial class FrmDMI : Form
    {

        public Compra MiCompraLocal { get; set; }
        public Producto MiProductoLocal { get; set; }
        public FrmDMI()
        {
            InitializeComponent();
            MiCompraLocal = new Compra();
            MiProductoLocal = new Producto();
        }

        private void FrmDMI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Control para el formulario (inicializacion de gestion de usuarios)

            if (!Globales.MiFormGestionUsuarios.Visible)
            {
                Globales.MiFormGestionUsuarios = new FrmUsuariosGestion();

                Globales.MiFormGestionUsuarios.Show();
            }
        }

        private void FrmDMI_Load(object sender, EventArgs e)
        {
            string InfoUsuario = string.Format("{0} - {1} ({2})",
                                        Globales.MiUsuarioGlobal.UsuarioNombre,
                                        Globales.MiUsuarioGlobal.UsuarioCorreo,
                                        Globales.MiUsuarioGlobal.MiRolTipo.UsuarioRolDescripcion);

            LblUsuario.Text = InfoUsuario;

            // Control para el formulario de gestion de usuarios dependiendo del usuario ADMIN-NORMAL
            switch (Globales.MiUsuarioGlobal.MiRolTipo.UsuarioRolID)
            {
                case 1:
                    // ADMIN: en este caso no se oculta nada
                    break;
                case 2:
                    // Normal: en este caso se ocupa esconder algunas opciones (Gestion de usuarios)
                    gestiónDeUsuariosToolStripMenuItem.Visible = false;
                    reporteDeComprasToolStripMenuItem.Visible = false;
                    break;
            }

        }
        // Control para el formulario (inicializacion de gestion de usuarios)

        private void gestiónDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormGestionProveedores.Visible)
            {
                Globales.MiFormGestionProveedores = new FrmProveedoresGestion();

                Globales.MiFormGestionProveedores.Show();
            }
        }

        // Control para el formulario (inicializacion de gestion de usuarios)

        private void gestiónDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormGestionProductos.Visible)
            {
                Globales.MiFormGestionProductos = new FrmCompraProductosGestion();

                Globales.MiFormGestionProductos.Show();
            }
        }

        private void ConsultaProductosDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormConsultaProductos.Visible)
            {
                Globales.MiFormConsultaProductos = new FrmConsultaInformacionCompra();

                Globales.MiFormConsultaProductos.Show();
            }
        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormGestionAgregarProductos.Visible)
            {
                Globales.MiFormGestionAgregarProductos = new FrmProductosAgregarGestion();

                Globales.MiFormGestionAgregarProductos.Show();
            }
        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void reporteDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormComprasListarVerReporte.Visible)
            {
                Globales.MiFormComprasListarVerReporte = new FrmComprasRptListarPorFechas();

                Globales.MiFormComprasListarVerReporte.Show();
            }

        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormVerReportes.Visible)
            {
                Globales.MiFormVerReportes = new FrmVisualizadorReportes();

                Globales.MiFormVerReportes.Show();

                ReportDocument MiReporteProductos = new ReportDocument();

                //se asigna un reporte al documento 
                MiReporteProductos = new Reportes.ProductosV2();

                MiReporteProductos = MiProductoLocal.Imprimir(MiReporteProductos);

                //se asigna este documento al visulizador de reportes (se usa para TODOS los reportes) 
                FrmVisualizadorReportes MiFormCRV = new FrmVisualizadorReportes();

                MiFormCRV.CrvComprasVisualizador.ReportSource = MiReporteProductos;

                MiFormCRV.Show();

                //para visualizar la página completa
                MiFormCRV.CrvComprasVisualizador.Zoom(1);
            }
        }

        private void reporteIndividualPorComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormVerReportes.Visible)
            {
                Globales.MiFormVerReportes = new FrmVisualizadorReportes();

                Globales.MiFormVerReportes.Show();
            }

            ReportDocument MiReporteListaCompras = new ReportDocument();

            //se asigna un reporte al documento 
            MiReporteListaCompras = new Reportes.CompraV2();

            MiReporteListaCompras = MiCompraLocal.Imprimir(MiReporteListaCompras);

            //se asigna este documento al visulizador de reportes (se usa para TODOS los reportes) 
            FrmVisualizadorReportes MiFormCRV = new FrmVisualizadorReportes();

            MiFormCRV.CrvComprasVisualizador.ReportSource = MiReporteListaCompras;

            MiFormCRV.Show();

            //para visualizar la página completa
            MiFormCRV.CrvComprasVisualizador.Zoom(1);

        }
    }
}
