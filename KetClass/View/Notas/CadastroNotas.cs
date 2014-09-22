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

        public CadastroNotas()
        {
            InitializeComponent();
            Notas = new List<NotaModel>();
        }

        private void CadastroNotas_Shown(object sender, EventArgs e)
        {
            if (turma != null)
            {
                lblTurma.Text = "Turma: " + turma.Display;
            }

            if (disciplina != null)
            {
                lblDisciplina.Text = disciplina.Descricao;
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
                Nota = Convert.ToInt32(tbxNota.Text),
                Faltas = Convert.ToInt32(tbxFaltas.Text),
                AulasDadas = Convert.ToInt32(tbxAulas.Text),
                TurmaId = turma.Id,
                Turma = turma,
                Disciplina = disciplina,
                DisciplinaId = disciplina.Id
            });

            tbxNota.Clear();
            tbxFaltas.Clear();
            tbxNumero.Text = (Convert.ToInt32(tbxNumero.Text) + 1).ToString();
            tbxNota.Focus();
        }
    }
}
