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
        public DataTable dt { get; set; }

        public CrystalReportsClass(ReportDocument pRpt)
        {
            Reporte = pRpt;
        }

        public CrystalReportsClass()
        {

        }

        public ReportDocument GenerarReporte()
        {
            if (dt.Rows.Count > 0)
            {
                Reporte.SetDataSource(dt);

                return Reporte;
            }
            else
            { return null; }
        }

    }
}

