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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
            {
                string usuario = TxtEmail.Text.Trim();
                string contrasennia = TxtContrasennia.Text.Trim();

                // Validar que los datos digitados sean correctos
                // Valores al usuario Global si la validación es correcta

                Globales.MiUsuarioGlobal = Globales.MiUsuarioGlobal.ValidarUsuario(usuario, contrasennia);

                //Validar si la asignacion de validacion anterior esta correcta 
                if (Globales.MiUsuarioGlobal.UsuarioID > 0)
                {
                    // Si la validacion es correcta el ID deberia tener un valor Mayor a 0
                    // se da el permiso para ingresar al sistema

                    Globales.MiFormPrincipal.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorecta", "Error de validacion", MessageBoxButtons.OK);

                    TxtContrasennia.Focus();
                    TxtContrasennia.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Faltan datos requeridos", "Error de validacion", MessageBoxButtons.OK);

            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnVerContrasennia_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = false;
        }

        private void BtnVerContrasennia_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = true;
        }
    }
}
