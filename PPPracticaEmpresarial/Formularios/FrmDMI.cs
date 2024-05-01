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
    public partial class FrmDMI : Form
    {
        public FrmDMI()
        {
            InitializeComponent();
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

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormVerReportes.Visible)
            {
                Globales.MiFormVerReportes = new FrmVisualizadorReportes();

                Globales.MiFormVerReportes.Show();
            }



        }
    }
}
