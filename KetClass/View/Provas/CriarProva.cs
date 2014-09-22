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

namespace KetClass.View.Provas
{
    public partial class CriarProva : Form
    {
        List<TurmaModel> turmas = new List<TurmaModel>();
        private TurmaController turmaController = new TurmaController();
        private DisciplinaController disciplinaController = new DisciplinaController();
        public CriarProva()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            cbxTurma.DataSource = turmaController.Index();
            cbxDisciplina.DataSource = disciplinaController.Index();
            listBox1.DataSource = turmas;
            listBox1.DisplayMember = "Display";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            turmas.Add((TurmaModel)cbxTurma.SelectedValue);
            
            listBox1.DataSource = null;
            listBox1.DataSource = turmas;
            listBox1.DisplayMember = "Display";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            turmas.Remove((TurmaModel)listBox1.SelectedValue);
            listBox1.DataSource = null;
            listBox1.DataSource = turmas;
            listBox1.DisplayMember = "Display";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KCContext context = KCContext.getInstance();
            foreach (TurmaModel turma in turmas)
            {
                ProvaModel prova = new ProvaModel();
                prova.Sinc = false;
                prova.Descricao = tbxConteudo.Text;
                prova.DataProva = dtpData.Value;
                var mes = dtpData.Value.Month;
                if (mes <= 5)
                {
                    prova.Trimestre = 1;
                }
                else if (mes <= 9)
                {
                    prova.Trimestre = 2;
                }
                else
                {
                    prova.Trimestre = 3;
                }
                prova.DisciplinaId = ((DisciplinaModel)cbxDisciplina.SelectedValue).Id;
                prova.TurmaId = turma.Id;
                prova.Recuperacao = cbxRec.Checked;
                prova.DataAlteracao = DateTime.Now;
                prova.DataCriacao = DateTime.Now;
                prova = context.Provas.Add(prova);
            }
            context.SaveChanges();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var mes = dtpData.Value.Month;
            MessageBox.Show(mes.ToString());
        }
    }
}
