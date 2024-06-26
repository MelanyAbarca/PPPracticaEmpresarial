﻿using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FrmCompraProductosGestion : Form
    {

        // Objetos de compra locales 
        public Compra MiCompraLocal { get; set; }

        public DataTable ListaProductos { get; set; }

        public FrmCompraProductosGestion()
        {
            InitializeComponent();
            MiCompraLocal = new Compra();
            ListaProductos = new DataTable();
            MdiParent = Globales.MiFormPrincipal;
        }

        private void FrmProductosGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;
            CargarTiposDeCompra();
            LimpiarForm();
        }

        private void CargarTiposDeCompra()
        {
            DataTable dtTiposCompra = new DataTable();
            dtTiposCompra = MiCompraLocal.MiTipoCompra.Listar();

            CboxCompraTipo.ValueMember = "id";
            CboxCompraTipo.DisplayMember = "descripcion";
            CboxCompraTipo.DataSource = dtTiposCompra;

            CboxCompraTipo.SelectedIndex = -1;
        }

        private void LimpiarForm()
        {
            TxtProveedorNombre.Clear();
            TxtNotas.Clear();
            TxtTotal.Text = "0";
            TxtTotalCantidad.Text = "0";
            CboxCompraTipo.SelectedIndex = -1;

            // Esquema en el DataTable del detalle (ListaProductos), como metodo de datasource del DgvLista sin
            // que elimine las comlumnas hechas en el tiempo de diseño.

            ListaProductos = new DataTable();

            ListaProductos = MiCompraLocal.CargarEsquemaDetalle();

            DgvLista.DataSource = ListaProductos;
        }

        // Bonton para buscar proveedores, nombrado(...)
        private void BtnProveedorBuscar_Click(object sender, EventArgs e)
        {
            // Se abre un nuevo formulario de busqueda de proveedor este formulario(Formulario sin definicion global)
            Form FormBusquedaProveedor = new FrmProveedorBuscar();

            // Variable de respuesta del formulario
            DialogResult respuesta = FormBusquedaProveedor.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                // Composiciones del proveedor para extraer el valor del nombre del proveedor
                TxtProveedorNombre.Text = MiCompraLocal.MiProveedor.ProveedorNombre;

            }
        }

        private void BtnProductoAgregar_Click(object sender, EventArgs e)
        {
            Form MiFormBusquedaItem = new FrmCompraAgregarProducto();
            DialogResult respuesta = MiFormBusquedaItem.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                DgvLista.DataSource = ListaProductos;

                Totalizar();
            }
        }

        // Funcion del total de los productos.

        private void Totalizar()
        {
            //Validar que el datatable tenga filas 
            if (ListaProductos.Rows.Count > 0)
            {
                // Recorrido del DT y realizacion de las operaciones matematicas
                decimal totalItems = 0;
                decimal totalMonto = 0;

                // Usar el recorrido de las filas
                foreach (DataRow row in ListaProductos.Rows)
                {
                    totalItems += Convert.ToDecimal(row["Cantidad"]);
                    // totalItems = totalItems + algo
                    totalMonto += Convert.ToDecimal(row["PrecioVentaUnitario"]) * Convert.ToDecimal(row["Cantidad"]);
                }

                // PARA EL TOTAL DE ITEMS // 
                TxtTotalCantidad.Text = totalItems.ToString();

                // PARA EL TOTAL DEL MONTO // 

                // Formula 1 de hacerlo: TxtTotal.Text = totalMonto.ToString();
                // Formula 2 de hacerlo: TxtTotal.Text = string.Format("{0:N2}",totalMonto) donde N2
                // significa que va a mostrar con 2 decimales 

                // Este formato, formula 2 para valores monetarios
                TxtTotal.Text = string.Format("{0:C2}", totalMonto);
            }
        }

        private void BtnCrearProducto_Click(object sender, EventArgs e)
        {
            // Validaciones de los campoos 

            if (ValidarCompra())
            {
                // Se agregan los datos de encabezao que hacen falta (de proveedor ya estan listos)

                MiCompraLocal.MiTipoCompra.CompraTipoID = Convert.ToInt32(CboxCompraTipo.SelectedValue);
                MiCompraLocal.CompraNotas = TxtNotas.Text.Trim();

                // Usuario direccto quemado(Masiel, por solicitid de Lorena)
                MiCompraLocal.MiUsuario.UsuarioID = 6;

                TrasladoDetalleListaVisualAObjetoCompra();

                // Se puede proceder a la funcion de agregar

                if (MiCompraLocal.Agregar())
                {
                    MessageBox.Show("Compra agregada correctamente!!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                //  Almacenar la informacion para el reporte //
                //se crea una var de tipo documento
                ReportDocument MiReporteCompra = new ReportDocument();

                //se asigna un reporte al documento 
                MiReporteCompra = new Reportes.CompraV2();

                MiReporteCompra = MiCompraLocal.Imprimir(MiReporteCompra);

                //se asigna este documento al visulizador de reportes (se usa para TODOS los reportes) 
                FrmVisualizadorReportes MiFormCRV = new FrmVisualizadorReportes();

                MiFormCRV.CrvComprasVisualizador.ReportSource = MiReporteCompra;

                MiFormCRV.Show();

                //para visualizar la página completa
                MiFormCRV.CrvComprasVisualizador.Zoom(1);

                LimpiarForm();
            }
        }

        private void TrasladoDetalleListaVisualAObjetoCompra()
        {
            // Pasamos los datos del DataTable que se usa graficamente a la List<> del objeto
            // MiCompraLocal

            foreach (DataRow fila in ListaProductos.Rows)
            {
                // se asigna el valor de composicion segun la clase CompraDetalle

                CompraDetalle nuevoDetalle = new CompraDetalle();
                nuevoDetalle.MiProducto.ProductoID = Convert.ToInt32(fila["ProductoID"]);
                nuevoDetalle.Cantidad = Convert.ToDecimal(fila["Cantidad"]);
                nuevoDetalle.PrecioUnitario = Convert.ToDecimal(fila["PrecioVentaUnitario"]);

                // Una vez que tenemos los datos en el nuevo detalle, se agrega ese objeto a la
                // lista de detalles de la compra local

                MiCompraLocal.ListaDetalles.Add(nuevoDetalle);
            }
        }

        // OPERACION DE LA VALIDACION
        private bool ValidarCompra()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()) &&
                                      CboxCompraTipo.SelectedIndex >= 0 &&
                                      ListaProductos.Rows.Count > 0)
            {
                R = true;
            }
            else
            {
                // Caso en que no haya seleccionado un proveedor
                if (string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()))
                {
                    MessageBox.Show("Se debe seleccionar un proveedor", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Caso en que no haya seleccionado un tipo de compra
                if (CboxCompraTipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe seleccionar un tipo compra", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Caso en que no haya dilas en el detalle
                if (ListaProductos.Rows.Count == 0)
                {
                    MessageBox.Show("Debe haber al menos una fila en el detalle", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }
            }

            return R;
        }

        private void DgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnListaCompras_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormConsultaProductos.Visible)
            {
                Globales.MiFormConsultaProductos = new FrmConsultaInformacionCompra();

                Globales.MiFormConsultaProductos.Show();
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
