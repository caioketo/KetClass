using KetClass.Controller;
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
    public partial class ClasseDetail : Form
    {
        private Controller<MatriculaModel> controller = new Controller<MatriculaModel>();

        public ClasseDetail(TurmaModel turma)
        {
            InitializeComponent();

            controller.dbset = controller.context.Matriculas;
            dataGridView1.DataSource = controller.dbset.Where(m => m.TurmaId == turma.Id).OrderBy(m => m.Aluno.Numero).ToList();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
            {
                HeaderText = "Nº",
                DataPropertyName = "AlunoNumero",
                Name = "NumeroC",
                DefaultCellStyle = new DataGridViewCellStyle(),
                Width = 50
            });
            dataGridView1.Columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
            {
                HeaderText = "Aluno",
                DataPropertyName = "AlunoNome",
                Name = "AlunoNomeC",
                DefaultCellStyle = new DataGridViewCellStyle(),
                Width = 400
            });
        }
    }
}
