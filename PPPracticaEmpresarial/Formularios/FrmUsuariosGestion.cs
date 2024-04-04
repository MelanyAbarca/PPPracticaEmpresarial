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
    public partial class FrmUsuariosGestion : Form
    {

        //Objeto local de usuarios
        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        //Lista local de usuarios que se visualizan en el datagridview

        private DataTable ListaUsuarios { get; set; }

        public FrmUsuariosGestion()
        {
            InitializeComponent();
            MiUsuarioLocal = new Logica.Models.Usuario();
            ListaUsuarios = new DataTable();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;
            CargarListaRoles();

            CargarListaDeUsuarios();
        }
        private void CargarListaDeUsuarios()
        {
            // Reseteo de la lista mediante una reinstancia

            ListaUsuarios = new DataTable();

            // Filtrar la lista de ususarios

            string FiltroBusqueda = "";
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {
                FiltroBusqueda = TxtBuscar.Text.Trim();
            }


            if (CboxVerActivos.Checked)
            {
                ListaUsuarios = MiUsuarioLocal.ListarActivos(FiltroBusqueda);
            }
            else
            {
                ListaUsuarios = MiUsuarioLocal.ListarInactivos(FiltroBusqueda);
            }

            DgLista.DataSource = ListaUsuarios;
        }



        private void CargarListaRoles()
        {

            Logica.Models.Usuario_Rol MiRol = new Logica.Models.Usuario_Rol();
            DataTable dt = new DataTable();
            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {

                CbRolesUsuario.ValueMember = "ID";
                CbRolesUsuario.DisplayMember = "Descrip";
                CbRolesUsuario.DataSource = dt;
                CbRolesUsuario.SelectedIndex = -1;

            }

        }

        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();
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

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Para seleccionar un usuarios en datagrid se debe cargar la info del mismo en el usuario local 
            // la informaci'on aparece en los controles graficos

            if (DgLista.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                // seleccion de la primera fila en indice 0
                DataGridViewRow MiFila = DgLista.SelectedRows[0];

                // Se agarra el valor del ID del usuario

                int IdUsuario = Convert.ToInt32(MiFila.Cells["CUsuarioID"].Value);

                // Reinstanciamiento del usuario local
                MiUsuarioLocal = new Logica.Models.Usuario();

                MiUsuarioLocal.UsuarioID = IdUsuario;

                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorIDRetornaUsuario();

                // Validacion de los datos en el usuario local 

                if (MiUsuarioLocal != null && MiUsuarioLocal.UsuarioID > 0)
                {

                    // Para llenar los controles 

                    TxtUsuarioID.Text = Convert.ToString(MiUsuarioLocal.UsuarioID);
                    TxtUsuarioNombre.Text = MiUsuarioLocal.UsuarioNombre;
                    TxtUsuarioCedula.Text = MiUsuarioLocal.UsuarioCedula;
                    TxtUsuarioTelefono.Text = MiUsuarioLocal.UsuarioTelefono;
                    TxtUsuarioCorreo.Text = MiUsuarioLocal.UsuarioCorreo;
                    TxtUsuarioDireccion.Text = MiUsuarioLocal.UsuarioDireccion;

                    // CBox
                    CbRolesUsuario.SelectedValue = MiUsuarioLocal.MiRolTipo.UsuarioRolID;
                }


            }


        }
    
        // BOTON AGREGAR
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                // Estas variables de almacenamiento de las consultas por correo y cedula
                bool CedulaOK;
                bool EmailOK;

                //Pasos 1.1 y 1.2
                MiUsuarioLocal = new Logica.Models.Usuario();

                // Llenar los valores de los atributos con los datos digitados en el form
                MiUsuarioLocal.UsuarioNombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.UsuarioCedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.UsuarioTelefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.UsuarioCorreo = TxtUsuarioCorreo.Text.Trim();
                MiUsuarioLocal.UsuarioContrasennia = TxtUsuarioContrasennia.Text.Trim();
                // Composicion del rol linea 205
                MiUsuarioLocal.MiRolTipo.UsuarioRolID = Convert.ToInt32(CbRolesUsuario.SelectedValue);
                MiUsuarioLocal.UsuarioDireccion = TxtUsuarioDireccion.Text.Trim();

                //Realizar las consultas por email y por cedula
                //Pasos 1.3 y 1.3.6 Almacenar un verdadero o falso
                //en cedula OK = Usuario local en consulta
                CedulaOK = MiUsuarioLocal.ConsultarPorCedula();

                // Pasos 1.4 y 1.4.6
                EmailOK = MiUsuarioLocal.ConsultarPorEmail();

                // Pasos 1.5 y 1.5.6
                if (CedulaOK == false && EmailOK == false)
                {
                    // Se puede agregar el usuario ya que no existe un usuario cpn cedula y correo
                    //digitados 

                    // Se solicita al usuario confirmacion de si quiere agregar o no al usuario

                    string msg = string.Format("¿Está seguro que desea agregar al usuario {0}?", MiUsuarioLocal.UsuarioNombre);
                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiUsuarioLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Usuario guardado corectamente!", ":)", MessageBoxButtons.OK);
                            LimpiarFormulario();

                            // Se carga nuevamente la lista con el usuario agregado
                            CargarListaDeUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("Usuario no se pudo agregar!", ":/", MessageBoxButtons.OK);
                        }
                    }


                }
                else
                {
                    // Indicar al usuario si falla alguna consulta

                    if (CedulaOK)
                    {
                        MessageBox.Show("Ya existe un usuario con la cedula digitada", "ERROR DE VALIDACION", MessageBoxButtons.OK);
                        return;
                    }

                    if (EmailOK)
                    {
                        MessageBox.Show("Ya existe un usuario con el correo digitado", "ERROR DE VALIDACION", MessageBoxButtons.OK);
                        return;
                    }

                }

            }
        }

        // BOTON MODIFICAR
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados(true))
            {

                MiUsuarioLocal.UsuarioNombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.UsuarioCedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.UsuarioTelefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.UsuarioCorreo = TxtUsuarioCorreo.Text.Trim();


                // Como el cuadro de texto de la contra tiene un caracter en blanco puedo 
                // asignar sin ningun problema el valor del cuadro de texto al atributo,
                // en el SP se evalua si tiene o no datos.

                MiUsuarioLocal.UsuarioContrasennia = TxtUsuarioContrasennia.Text.Trim();

                MiUsuarioLocal.MiRolTipo.UsuarioRolID = Convert.ToInt32(CbRolesUsuario.SelectedValue);

                MiUsuarioLocal.UsuarioDireccion = TxtUsuarioDireccion.Text.Trim();

                // Al editar se toma en cuenta el ID

                if (MiUsuarioLocal.ConsultarPorID())
                {
                    DialogResult respuesta = MessageBox.Show(" Esta seguro que desea modificar el usuario?", "???",
                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Editar())
                        {

                            MessageBox.Show("El Usuario ha sido modificado correctamente", ":)",
                                            MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDeUsuarios();


                        }
                    }

                }

            }

        }

        // BOTON LIMPIAR 
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            DgLista.ClearSelection();
        }
        private void LimpiarFormulario()
        {
            TxtUsuarioID.Clear();
            TxtUsuarioNombre.Clear();
            TxtUsuarioCedula.Clear();
            TxtUsuarioTelefono.Clear();
            TxtUsuarioCorreo.Clear();
            TxtUsuarioContrasennia.Clear();

            CbRolesUsuario.SelectedIndex = -1;

            TxtUsuarioDireccion.Clear();
        }

        // Funcion para evaluar que se hayan digitado los campos de texto en el formulario
        private bool ValidarDatosDigitados(bool OmitirPassword = false)
        {
            Boolean R = false;

            if (!string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()) &&
                CbRolesUsuario.SelectedIndex > -1)
            {

                if (OmitirPassword)
                {
                    R = true;
                }
                else
                {
                    // (PARA AGREGAR) en caso en el que haya que evaluar la contra se debe agregar
                    //condicion
                    // logica

                    if (!string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()))
                    {
                        R = true;
                    }
                    else
                    {
                        // Indicacion de que hace falta una contra
                        MessageBox.Show("Debe digitar una contraseña para el usuario", "Error de validacion", MessageBoxButtons.OK);
                        TxtUsuarioContrasennia.Focus();
                        return false;

                    }
                }
            }
            else
            {
                // Evaluacion para cuando falta algo
                // Nombre
                if (string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un nombre para el usuario", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioNombre.Focus();
                    return false;
                }

                //Cedula
                if (string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un cedula para el usuario", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioCedula.Focus();
                    return false;
                }

                //Telefono
                if (string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un telefono para el usuario", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioTelefono.Focus();
                    return false;
                }

                //Correo
                if (string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un correo para el usuario", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioCorreo.Focus();
                    return false;
                }

                // Roles de usuario
                if (CbRolesUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un rol para el usuario", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioContrasennia.Focus();
                    return false;
                }
            }

            return R;
        }

        // BOTON CANCELAR
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //Application.Exit(FrmDMI);
        }

        // BOTON ELIMINAR 
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiUsuarioLocal.UsuarioID > 0 && MiUsuarioLocal.ConsultarPorID())
            {

                if (CboxVerActivos.Checked)
                {
                    // Desactivar usuario
                    DialogResult r = MessageBox.Show("Esta seguro de eliminar al usuario", "??",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Eliminar())
                        {
                            MessageBox.Show("El usuario ha sido eliminado correctamente",
                                             "!!", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaDeUsuarios();
                        }
                    }

                }
                else
                {
                    // Activar usuario
                    DialogResult r = MessageBox.Show("Esta seguro de activar nuevamente al usuario", "??",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Activar())
                        {
                            MessageBox.Show("El usuario ha sido activado correctamente",
                                             "!!", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaDeUsuarios();
                        }
                    }

                }

            }
        }


        // Traer la infromacion de los campos de texto para escribirla mediante las validaciones//
        private void TxtUsuarioNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtUsuarioCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }

        private void TxtUsuarioTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);
        }

        private void TxtUsuarioCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false, true);
        }

        private void TxtUsuarioContrasennia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);
        }

        private void TxtUsuarioDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }
        
        
        // Validar si el correo esta incorrecto
        private void TxtUsuarioCorreo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
            {
                if (!Validaciones.ValidarEmail(TxtUsuarioCorreo.Text.Trim()))
                {
                    MessageBox.Show("El formato del correo es incorrecto", "ERROR DE VALIDACION", MessageBoxButtons.OK);
                    TxtUsuarioCorreo.Focus();
                }
            }
        }

        private void TxtUsuarioCorreo_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
            {
                TxtUsuarioCorreo.SelectAll();
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarListaDeUsuarios();
        }

        private void CboxVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarListaDeUsuarios();
            if (CboxVerActivos.Checked)
            {
                BtnEliminar.Text = "Eliminar";
            }
            else
            {
                BtnEliminar.Text = "Activar";
            }
        }

        private void DgLista_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();
        }

        private void DgLista_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Seleccion de la fila, para traer la info del control 

            if (DgLista.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                DataGridViewRow MiFila = DgLista.SelectedRows[0];

                int IdUsuario = Convert.ToInt32(MiFila.Cells["CUsuarioID"].Value);

                // Reinstancia del usuario local
                MiUsuarioLocal = new Logica.Models.Usuario();


                // Valor ID del usuario local
                MiUsuarioLocal.UsuarioID = IdUsuario;
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorIDRetornaUsuario();

                // Validamos que el usuario local tenga datos 

                if (MiUsuarioLocal != null && MiUsuarioLocal.UsuarioID > 0)
                {

                    // Se llena los controles 

                    TxtUsuarioID.Text = Convert.ToString(MiUsuarioLocal.UsuarioID);
                    TxtUsuarioNombre.Text = MiUsuarioLocal.UsuarioNombre;
                    TxtUsuarioCedula.Text = MiUsuarioLocal.UsuarioCedula;
                    TxtUsuarioTelefono.Text = MiUsuarioLocal.UsuarioTelefono;
                    TxtUsuarioCorreo.Text = MiUsuarioLocal.UsuarioCorreo;
                    TxtUsuarioDireccion.Text = MiUsuarioLocal.UsuarioDireccion;

                    // Cbox del tipo de usuario
                    CbRolesUsuario.SelectedValue = MiUsuarioLocal.MiRolTipo.UsuarioRolID;

                }
            }
        }
    }
}
