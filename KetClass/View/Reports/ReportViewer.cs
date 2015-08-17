using KetClass.Data;
using KetClass.Model;
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

namespace KetClass.View.Reports
{
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
            BindingList<MatriculaModel> matriculas = new BindingList<MatriculaModel>(
                KCContext.getInstance().Matriculas.Where(m => m.TurmaId == 1).ToList());

            MatriculaModelBindingSource.DataSource = matriculas;
            ReportParameter param = new ReportParameter("classeDisplay", "teste");
            reportViewer1.LocalReport.SetParameters(param);
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
