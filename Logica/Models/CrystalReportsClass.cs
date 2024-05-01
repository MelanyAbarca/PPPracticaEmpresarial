using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class CrystalReportsClass
    {

        //Forma del reporte 
        public ReportDocument Reporte { get; set; }

        //contiene la data que se visuliza en el reporte
        public DataTable Datos { get; set; }

        public CrystalReportsClass(ReportDocument pRpt)
        {
            Reporte = pRpt;
        }

        public CrystalReportsClass()
        {

        }

        public ReportDocument GenerarReporte()
        {
            if (Datos.Rows.Count > 0)
            {
                Reporte.SetDataSource(Datos);

                return Reporte;
            }
            else
            { return null; }
        }

    }
}

