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
        public ReciboViewer(double valorMissoes,
                            double valorOfertas, 
                            string membro, 
                            string cong,
                            double total)
        {
            InitializeComponent();

            reportViewer1.LocalReport.ReportPath = "../../../Recibo.rdlc";
           
            Microsoft.Reporting.WinForms.ReportParameter[] p =
                new Microsoft.Reporting.WinForms.ReportParameter[6];
            p[0] = new Microsoft.Reporting.WinForms.ReportParameter("ValorMissoes", valorMissoes.ToString("C"));
            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("ValorOferta", valorOfertas.ToString("C"));
            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("Membro", membro);
            p[3] = new Microsoft.Reporting.WinForms.ReportParameter("Cong", cong);
            p[4] = new Microsoft.Reporting.WinForms.ReportParameter("Total", ( total.ToString("C")));
            p[5] = new Microsoft.Reporting.WinForms.ReportParameter("Data", DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            reportViewer1.LocalReport.SetParameters(p);

            reportViewer1.RefreshReport();
        }
       
        private void ReciboViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
