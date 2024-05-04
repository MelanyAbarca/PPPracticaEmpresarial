using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FrmComprasRptListarPorFechas : Form
    {
        public Compra MiCompraLocal { get; set; }
        
        public FrmComprasRptListarPorFechas()
        {
            InitializeComponent();
            MiCompraLocal = new Compra();
            MdiParent = Globales.MiFormPrincipal;
        }

        //private void Buscar()
        //{//funcion para buscar los comprobantes entre fechas
        //    try
        //    {
        //        DgvList.DataSource = DCompra.ConsultarFechas(Convert.ToDateTime(DtpFechaInicio.Value), Convert.ToDateTime(DtpFechaFin.Value));
        //        this.Formato();
        //        this.Limpiar();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message + ex.StackTrace);
        //    }
        //}
        private bool ValidarCompraFechas()
        {
            bool R = false;
            DateTime FechaInicio = DtpFechaInicio.Value.Date;
            DateTime FechaFin = DtpFechaFin.Value.Date;

            // Captura los valores seleccionados
            if (FechaInicio != DateTime.MinValue && FechaFin != DateTime.MinValue)
            {
                if (FechaFin >= FechaInicio)
                {

                    MessageBox.Show("Fecha de inicio: " + FechaInicio.ToString() + "\nFecha de fin: " + 
                        FechaFin.ToString(), "Fechas seleccionadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La fecha de fin debe ser posterior o igual a la fecha de inicio.", "Error de fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    return false;
                }
                R = true;
            }
            else
            {
                    MessageBox.Show("Se debe seleccionar una fecha de inicio y una fecha de fin para la consulta", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
            }

            return R;
        }

        private void BtnVerReporte_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = DtpFechaInicio.Value.Date;
            DateTime fechaFin = DtpFechaFin.Value.Date;

            if (ValidarCompraFechas())
            {

                MiCompraLocal.CompraFecha= DtpFechaInicio.Value;
               // MiCompraLocal.MiCompraFecha = Convert.ToString(DtpFechaInicio.Value);


                ReportDocument MiReporteListaCompras = new ReportDocument();

                //se asigna un reporte al documento 
                MiReporteListaCompras = new Reportes.ComprasListarV2();

                MiReporteListaCompras = MiCompraLocal.ImprimirPorFecha(MiReporteListaCompras);

                //se asigna este documento al visulizador de reportes (se usa para TODOS los reportes) 
                FrmVisualizadorReportes MiFormCRV = new FrmVisualizadorReportes();

                MiFormCRV.CrvComprasVisualizador.ReportSource = MiReporteListaCompras;

                MiFormCRV.Show();

                //para visualizar la página completa
                MiFormCRV.CrvComprasVisualizador.Zoom(1);
            }









        }




    }
}
