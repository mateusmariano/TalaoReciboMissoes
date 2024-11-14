using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ReciboMissoes
{
    public partial class ReciboViewer : Form
    {
        public ReciboViewer(ClasseRecibo classeRecibo)
        {
            InitializeComponent();

            reportViewer1.LocalReport.ReportPath = "../../../Recibo.rdlc";
           
            Microsoft.Reporting.WinForms.ReportParameter[] p =
                new Microsoft.Reporting.WinForms.ReportParameter[7];
            p[0] = new Microsoft.Reporting.WinForms.ReportParameter("ValorMissoes", classeRecibo.MissoesValor.ToString("C"));
            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("ValorOferta", classeRecibo.OfertaValor.ToString("C"));
            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("Membro", classeRecibo.Membro);
            p[3] = new Microsoft.Reporting.WinForms.ReportParameter("Cong", classeRecibo.Congregacao);
            p[4] = new Microsoft.Reporting.WinForms.ReportParameter("Total", (classeRecibo.Total.ToString("C")));
            p[5] = new Microsoft.Reporting.WinForms.ReportParameter("Data", classeRecibo.Data.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            p[6] = new Microsoft.Reporting.WinForms.ReportParameter("NumeroRecibo", classeRecibo.NumeroRecibo.ToString("D4"));
            reportViewer1.LocalReport.SetParameters(p);

            reportViewer1.RefreshReport();
        }

        private void ReciboViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
