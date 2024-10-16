using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketApp.Services.Data;

namespace TicketApp.Vistas.Reports
{
    public partial class ReporteHistorial : Form
    {
        private readonly List<Solicitud> solicitudes;

        public ReporteHistorial(List<Solicitud> solicitudes)
        {
            InitializeComponent();
            this.solicitudes = solicitudes;
        }

        private void ReporteHistorial_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "TicketApp.Vistas.Reports.Historial.rdlc";


            DataSet ds = new DataSet();
            DataTable dt = new DataTable("Solicitudes");

            dt.Columns.Add("Usuario", typeof(string));
            dt.Columns.Add("Departamento", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("EstadoActual", typeof(string));
            dt.Columns.Add("Fecha", typeof(DateTime));

            foreach (var solicitud in solicitudes)
            {
                dt.Rows.Add(solicitud.Usuario, solicitud.Departamento, solicitud.Descripcion, solicitud.EstadoActual, solicitud.Fecha);
            }

            ds.Tables.Add(dt);

            ReportDataSource rds = new ReportDataSource("DataSetSolicitudes", ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }
    }
}
