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

namespace KetClass.View.Notas
{
    public partial class CadastroNotas : Form
    {
        public List<NotaModel> Notas;
        public TurmaModel turma;
        public DisciplinaModel disciplina;
        private Controller.Controller<NotaModel> NotaController = new Controller.Controller<NotaModel>();

        public CadastroNotas()
        {
            InitializeComponent();
            NotaController.dbset = NotaController.context.Notas;
            Notas = new List<NotaModel>();

            dgvNotas.AutoGenerateColumns = false;
            dgvNotas.Columns.Clear();
            dgvNotas.Columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
            {
                HeaderText = "Número",
                DataPropertyName = "Numero",
                Name = "NumeroC",
                DefaultCellStyle = new DataGridViewCellStyle()
            });
            dgvNotas.Columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
            {
                HeaderText = "Nota",
                DataPropertyName = "Nota",
                Name = "NotaC",
                DefaultCellStyle = new DataGridViewCellStyle()
            });
            dgvNotas.Columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
            {
                HeaderText = "Faltas",
                DataPropertyName = "Faltas",
                Name = "FaltasC",
                DefaultCellStyle = new DataGridViewCellStyle()
            });
            dgvNotas.DataSource = Notas;
        }

        private void CadastroNotas_Shown(object sender, EventArgs e)
        {
            if (turma != null)
            {
                lblTurma.Text = "Turma: " + turma.Display;
            }

            if (disciplina != null)
            {
                lblDisciplina.Text = "Disciplina: " + disciplina.Descricao;
            }

            tbxNumero.Text = "1";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxNota.Text) || String.IsNullOrEmpty(tbxNumero.Text) ||
                String.IsNullOrEmpty(tbxAulas.Text))
            {
                MessageBox.Show("Favor preencher todos os campos");
                return;
            }

            Notas.Add(new NotaModel() 
            {
                Numero = Convert.ToInt32(tbxNumero.Text),
                Nota = Convert.ToDouble(tbxNota.Text),
                Faltas = Convert.ToInt32(tbxFaltas.Text.Equals("") ? "0" : tbxFaltas.Text),
                AulasDadas = Convert.ToInt32(tbxAulas.Text),
                TurmaId = turma.Id,
                Turma = turma,
                Disciplina = disciplina,
                DisciplinaId = disciplina.Id,
                Trimestre = Convert.ToInt32(tbxTrimestre.Text)
            });

            tbxNota.Clear();
            tbxFaltas.Clear();
            tbxNumero.Text = (Convert.ToInt32(tbxNumero.Text) + 1).ToString();
            tbxNota.Focus();

            dgvNotas.DataSource = null;
            dgvNotas.DataSource = Notas;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (NotaModel nota in Notas)
            {
                NotaController.Create(nota);
            }
            this.Close();
        }
    }
}
