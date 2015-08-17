using KetClass.Controller;
using KetClass.Data;
using KetClass.Model;
using KetClass.View.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetClass.View.Notas
{
    public partial class CadastroNotas : Form
    {
        public bool Recuperacao = false;
        public bool RecCriada = false;
        public List<NotaModel> Notas;
        public TurmaModel turma;
        public DisciplinaModel disciplina;
        private Controller.Controller<NotaModel> NotaController = new Controller.Controller<NotaModel>();
        Progresso progresso = new Progresso();
        private List<double> NotasRec = new List<double>();
        

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
            groupBox1.TabStop = false;
            groupBox1.GotFocus += groupBox1_GotFocus;
        }

        void groupBox1_GotFocus(object sender, EventArgs e)
        {
            SelectNextControl(Utils.Util.FindFocusedControl(this), true, true, true, true);
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
            tbxFaltas.Enabled = true;
            tbxNota.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            cbxDispensado.Enabled = true;
            tbxAulas.Enabled = true;

            dgvNotas.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((!cbxDispensado.Checked && String.IsNullOrEmpty(tbxNota.Text)) || String.IsNullOrEmpty(tbxNumero.Text) ||
                String.IsNullOrEmpty(tbxAulas.Text))
            {
                MessageBox.Show("Favor preencher todos os campos");
                return;
            }

            Notas.Add(new NotaModel() 
            {
                Numero = Convert.ToInt32(tbxNumero.Text),
                Nota = Convert.ToDouble(cbxDispensado.Checked ? "-1" : tbxNota.Text),
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
            foreach (DataGridViewRow row in dgvNotas.Rows)
            {
                NotasRec.Add(Convert.ToDouble(row.Cells[3].Value));
            }
            progresso.Iniciar(backgroundWorker1, Notas.Count, "Gravando...");
            //Controller<AlunoModel> alunoControler = new Controller<AlunoModel>();
            //alunoControler.dbset = alunoControler.context.Alunos;
            //foreach (NotaModel nota in Notas)
            //{
                //nota.AlunoId = alunoControler.Index().Where(a => a.Numero == nota.Numero && a.Turma.Id == nota.TurmaId).FirstOrDefault().Id;
                //NotaController.Create(nota);
            //}
            //this.Close();
        }

        private void CadastroNotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SelectNextControl(Utils.Util.FindFocusedControl(this), true, true, true, true);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Controller<BoletimWebModel> boletimController = new Controller<BoletimWebModel>();
            Controller<AlunoModel> alunoControler = new Controller<AlunoModel>();
            alunoControler.dbset = alunoControler.context.Alunos;
            boletimController.dbset = boletimController.context.BoletinsWeb;
            int count = 0;
            foreach (NotaModel nota in Notas)
            {                
                if (Recuperacao)
                {
                    NotaModel notaRec = new NotaModel(nota);
                    notaRec.Recupercao = true;
                    notaRec.Nota = NotasRec[count];
                    NotaController.Create(notaRec);
                }
                else
                {
                    nota.AlunoId = alunoControler.Index().Where(a => a.Numero == nota.Numero && a.Turma.Id == nota.TurmaId).FirstOrDefault().Id;
                    NotaController.Create(nota);
                }
                if (boletimController.Filter(b => b.AlunoId == nota.AlunoId && b.DisciplinaId == nota.DisciplinaId).ToList().Count > 0)
                {
                    BoletimWebModel boletimWeb = boletimController.Filter(b => b.AlunoId == nota.AlunoId && b.DisciplinaId == nota.DisciplinaId).First();
                    boletimWeb.PrecisaSinc = true;
                    boletimController.Edit(boletimWeb);
                }
                count++;
                backgroundWorker1.ReportProgress(count);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progresso.Close();
            this.Close();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progresso.SetPosition(e.ProgressPercentage);
        }

        private void tbxTrimestre_Leave(object sender, EventArgs e)
        {
            if (Recuperacao && !RecCriada)
            {
                RecCriada = true;
                int trim = Convert.ToInt32(tbxTrimestre.Text);
                Notas = NotaController.Filter(n => n.TurmaId == turma.Id && n.DisciplinaId == disciplina.Id &&
                    n.Nota < 5 && n.Trimestre == trim).ToList();

                dgvNotas.DataSource = null;

                foreach (DataGridViewColumn col in dgvNotas.Columns)
                {
                    col.ReadOnly = true;
                }
                dgvNotas.Columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Rec",
                    DataPropertyName = "Rec",
                    Name = "RecC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });

                dgvNotas.EditMode = DataGridViewEditMode.EditOnEnter;

                tbxFaltas.Enabled = false;
                tbxNota.Enabled = false;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                cbxDispensado.Enabled = false;
                tbxAulas.Enabled = false;
                dgvNotas.DataSource = Notas;
                dgvNotas.Focus();
            }
        }
    }
}
