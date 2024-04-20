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
    public partial class FrmConsultaProductos : Form
    {
        // Onjeto local de compra
        private Logica.Models.Compra MiCompraLocal { get; set; }

        //Lista local de compras que se visualizan en el datagridview

        private DataTable ListaCompras { get; set; }

        public FrmConsultaProductos()
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


            if (CboxVerActivos.Checked)
            {
                ListaCompras = MiCompraLocal.ListarActivos(FiltroBusqueda);
            }
            else
            {
                ListaCompras = MiCompraLocal.ListarInactivos(FiltroBusqueda);
            }

            DgvLista.DataSource = ListaCompras;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormGestionProductos.Visible)
            {
                Globales.MiFormGestionProductos = new FrmProductosGestion();

                Globales.MiFormGestionProductos.Show();

                CargarListaDeCompras();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

        }
        //private void LimpiarFormulario()
        //{
        //    TxtUsuarioID.Clear();
        //    TxtUsuarioNombre.Clear();
        //    TxtUsuarioCedula.Clear();
        //    TxtUsuarioTelefono.Clear();
        //    TxtUsuarioCorreo.Clear();
        //    TxtUsuarioContrasennia.Clear();

        //    CbRolesUsuario.SelectedIndex = -1;

        //    TxtUsuarioDireccion.Clear();
        //}

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiCompraLocal.CompraID > 0 && MiCompraLocal.ConsultarCompraPorID())
            {

                if (CboxVerActivos.Checked)
                {
                    // Desactivar usuario
                    DialogResult r = MessageBox.Show("Esta seguro de eliminar la informacion de la compra", "Eliminar Productos",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        if (MiCompraLocal.Eliminar())
                        {
                            MessageBox.Show("La compra ha sido eliminada correctamente",
                                             "Productos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            // LimpiarFormulario();
                            CargarListaDeCompras();
                        }
                    }

                }
                else
                {
                    // Activar la compra
                    DialogResult r = MessageBox.Show("Esta seguro de activar nuevamente la compra", "Reactivar Productos",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        if (MiCompraLocal.Activar())
                        {
                            MessageBox.Show("Los productos de la compra han sido activados correctamente",
                                             "Activación satisfactoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                           // LimpiarFormulario();
                            CargarListaDeCompras();
                        }
                    }
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarListaDeCompras();
        }


        private void CboxVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarListaDeCompras();
            if (CboxVerActivos.Checked)
            {
                BtnEliminar.Text = "Eliminar";
            }
            else
            {
                BtnEliminar.Text = "Activar";
            }
        }

        private void DgvLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvLista.ClearSelection();
        }

        private void DgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}