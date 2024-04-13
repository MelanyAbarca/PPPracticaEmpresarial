﻿using System;
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
    public partial class FrmProveedoresGestion : Form
    {

        //OBJETO LOCAL PARA PROVEEDORES
        private Logica.Models.Proveedor MiProveedorLocal { get; set; }



        private DataTable ListaProveedores { get; set; }
        public FrmProveedoresGestion()
        {
            InitializeComponent();
            MiProveedorLocal = new Logica.Models.Proveedor();
            ListaProveedores = new DataTable();
        }

        private void FrmProveedoresGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;
            CargarListaDeProveedores();
            CargarListaTiposProveedor();
        }

        // Para Cargar la lista de los proveedores
        private void CargarListaDeProveedores()
        {
            // Resetear la lista de usuarios haciendo re instancia del objeto

            ListaProveedores = new DataTable();

            //Filtrar la lista para tres o mas caracteres

            string FiltroBusqueda = " ";
            if (!string.IsNullOrEmpty(TxtBuscarProveedor.Text.Trim()) && TxtBuscarProveedor.Text.Count() >= 3)
            {
                FiltroBusqueda = TxtBuscarProveedor.Text.Trim();
            }


            if (CboxVerActivos.Checked)
            {
                ListaProveedores = MiProveedorLocal.ListarActivos(FiltroBusqueda);
            }
            else
            {
                ListaProveedores = MiProveedorLocal.ListarInactivos(FiltroBusqueda);
            }

            DgLista.DataSource = ListaProveedores;
        }

        // Para Cargar la lista de los tipoes de proveedores 
        private void CargarListaTiposProveedor()
        {

            Logica.Models.TipoProveedor MiTipoProveedor = new Logica.Models.TipoProveedor();
            DataTable dt = new DataTable();
            dt = MiTipoProveedor.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbTipoProveedor.ValueMember = "ID";
                CbTipoProveedor.DisplayMember = "Descrip";
                CbTipoProveedor.DataSource = dt;
                CbTipoProveedor.SelectedIndex = -1;
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            LimpiarFormulario();
        }


        // VALIDACION DE LOS DATOS PARA AGREGAR UN NUEVO PROVEEDOR // 
        private bool ValidarDatosDigitados(bool OmitirPassword = false)
        {
            Boolean R = false;

            if (!string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProveedorCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProveedorCorreo.Text.Trim()) &&
                CbTipoProveedor.SelectedIndex > -1)
            {

            }
            else
            {
                // Evaluar que pasa cuando algo falta
                // Nombre
                if (string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un nombre para el proveedor", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtProveedorNombre.Focus();
                    return false;
                }

                //Cedula
                if (string.IsNullOrEmpty(TxtProveedorCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un cedula para el proveedor", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtProveedorCedula.Focus();
                    return false;
                }

                //Correo
                if (string.IsNullOrEmpty(TxtProveedorCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un correo para el proveedor", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtProveedorCorreo.Focus();
                    return false;
                }

            }

            return R;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {


                // Estas variables almacenan el resultado de las consultas por correo y cedula
                bool CedulaOK;
                bool EmailOK;


                MiProveedorLocal = new Logica.Models.Proveedor();

                // Llenar los valores de los atributos con los datos digitados en el form
                MiProveedorLocal.ProveedorNombre = TxtProveedorNombre.Text.Trim();
                MiProveedorLocal.ProveedorCedula = TxtProveedorCedula.Text.Trim();
                MiProveedorLocal.ProveedorEmail = TxtProveedorCorreo.Text.Trim();

                // Composicion del tipo de Proveedor
                MiProveedorLocal.MiTipoProveedor.Id = Convert.ToInt32(CbTipoProveedor.SelectedValue);
                MiProveedorLocal.ProveedorDireccion = TxtProveedorDireccion.Text.Trim();


                CedulaOK = MiProveedorLocal.ConsultarPorCedula();
                EmailOK = MiProveedorLocal.ConsultarPorEmail();


                if (CedulaOK == false && EmailOK == false)
                {
                    // Se puede agregar el proveedor ya que no existe un usuario con cedula y correo
                    //digitados 

                    // Se solicita al usuario confirmacion de si quiere agregar o no al proveedor

                    string msg = string.Format("¿Está seguro que desea agregar al proveedor {0}?", MiProveedorLocal.ProveedorNombre);
                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiProveedorLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Proveedor guardado corectamente!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            LimpiarFormulario();

                            CargarListaDeProveedores();
                        }
                        else
                        {
                            MessageBox.Show("El proveedor no se pudo agregar!", ":/", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                }
                else
                {
                    // Indicar al usuario si falla alguna consulta

                    if (CedulaOK)
                    {
                        MessageBox.Show("Ya existe un proveedor con la cedula digitada", "ERROR DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (EmailOK)
                    {
                        MessageBox.Show("Ya existe un proveedor con el correo digitado", "ERROR DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }

            }
        }

        // Validaciones 
        private void TxtProveedorNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }
        private void TxtProveedorCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }
        private void TxtProveedorCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }
        private void TxtProveedorDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }


        private void TxtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            CargarListaDeProveedores();
        }

        private void TxtUsuarioCorreo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtProveedorCorreo.Text.Trim()))
            {
                if (!Validaciones.ValidarEmail(TxtProveedorCorreo.Text.Trim()))
                {
                    MessageBox.Show("El formato del correo es incorrecto", "ERROR DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtProveedorCorreo.Focus();
                }
            }
        }
        private void DgLista_BindingComplete(object sender, EventArgs e)
        {
            DgLista.ClearSelection();
        }
        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnCancelar.Enabled = false;
        }
        private void ActivarCancelar()
        {
            BtnAgregar.Enabled = false;
            BtnCancelar.Enabled = true;
        }

        // Para limpiar el formulkario
        private void LimpiarFormulario()
        {
            TxtProveedorID.Clear();
            TxtProveedorNombre.Clear();
            TxtProveedorCedula.Clear();
            TxtProveedorCorreo.Clear();
            CbTipoProveedor.SelectedIndex = -1;
            TxtProveedorDireccion.Clear();
        }
        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgLista.SelectedRows.Count == 1)
            {
                LimpiarFormulario();


                DataGridViewRow MiFila = DgLista.SelectedRows[0];

                int IdProveedor = Convert.ToInt32(MiFila.Cells["CProveedorID"].Value);

                // Reinstanciacion del proveedor local
                MiProveedorLocal = new Logica.Models.Proveedor();


                //Valor obtenido por la fila ID del proveedor local
                MiProveedorLocal.ProveedorID = IdProveedor;

                //Ralizar consultar el usuario por ese id y llenar el resto de atributos.

                MiProveedorLocal = MiProveedorLocal.ConsultarPorIDRetornaProveedor();

                // Validacion de datos del proveedor local

                if (MiProveedorLocal != null && MiProveedorLocal.ProveedorID > 0)
                {

                    // Si lo cargamos correctamente el usuario local llenamos los controles
                    TxtProveedorID.Text = Convert.ToString(MiProveedorLocal.ProveedorID);
                    TxtProveedorNombre.Text = MiProveedorLocal.ProveedorNombre;
                    TxtProveedorCedula.Text = MiProveedorLocal.ProveedorCedula;
                    TxtProveedorCorreo.Text = MiProveedorLocal.ProveedorEmail;
                    TxtProveedorDireccion.Text = MiProveedorLocal.ProveedorDireccion;

                    // Combobox
                    CbTipoProveedor.SelectedValue = MiProveedorLocal.MiTipoProveedor.ProveedorTipoDescripcion;

                }
            }
        }

        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados(true))
            {

                MiProveedorLocal.ProveedorNombre = TxtProveedorNombre.Text.Trim();
                MiProveedorLocal.ProveedorCedula = TxtProveedorCedula.Text.Trim();
                MiProveedorLocal.ProveedorEmail = TxtProveedorCorreo.Text.Trim();


                // Atributo que en el SP se evalua si tiene o no datos.

                MiProveedorLocal.MiTipoProveedor.ProveedorTipoDescripcion= Convert.ToString(CbTipoProveedor.SelectedValue);

                MiProveedorLocal.ProveedorDireccion = TxtProveedorDireccion.Text.Trim();

                // Al editar se toma en cuenta el ID

                if (MiProveedorLocal.ConsultarPorID())
                {
                    DialogResult respuesta = MessageBox.Show(" Esta seguro que desea modificar el proveedor?", "Modificación de usuarios",
                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiProveedorLocal.Editar())
                        {

                            MessageBox.Show("El proveedor ha sido modificado correctamente", "Proveedor modificado",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            LimpiarFormulario();
                            CargarListaDeProveedores();

                        }
                    }

                }

            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            DgLista.ClearSelection();
        }
      

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiProveedorLocal.ProveedorID > 0 && MiProveedorLocal.ConsultarPorID())
            {

                if (CboxVerActivos.Checked)
                {
                    // Desactivar usuario
                    DialogResult r = MessageBox.Show("Esta seguro de eliminar al usuario", "Eliminar usuario",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        if (MiProveedorLocal.Eliminar())
                        {
                            MessageBox.Show("El usuario ha sido eliminado correctamente",
                                             "Usuario eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            LimpiarFormulario();
                            CargarListaDeProveedores();
                        }
                    }

                }
                else
                {
                    // Activar usuario
                    DialogResult r = MessageBox.Show("Esta seguro de activar nuevamente al proveedor", "Reactivar Usuario",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        if (MiProveedorLocal.Activar())
                        {
                            MessageBox.Show("El proveedor ha sido activado correctamente",
                                             "Activación satisfactoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            LimpiarFormulario();
                            CargarListaDeProveedores();
                        }
                    }
                }
            }
        }
    }
}
