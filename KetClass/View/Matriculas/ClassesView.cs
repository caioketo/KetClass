using KetClass.Controller;
using KetClass.Data;
using KetClass.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetClass.View.Matriculas
{
    public partial class ClassesView : Form
    {
        private Controller<MatriculaModel> controller = new Controller<MatriculaModel>();
        public ClassesView()
        {
            InitializeComponent();
            controller.dbset = controller.context.Matriculas;


            dataGridView1.DataSource = controller.context.Turmas.Where(t => controller.dbset.GroupBy(m => new { 
                m.TurmaId 
            }).Select(g => g.Key.TurmaId).ToList().Contains(t.Id)).OrderBy(t => t.Serie).ToList();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
            {
                HeaderText = "Turma",
                DataPropertyName = "Display",
                Name = "DisplayC",
                DefaultCellStyle = new DataGridViewCellStyle()
            });
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TurmaModel turma = (TurmaModel)dataGridView1.SelectedRows[0].DataBoundItem;
            using (ClasseDetail c = new ClasseDetail(turma))
            {
                c.ShowDialog();
            }
        }
    }
}
