using KetClass.Controller;
using KetClass.Data;
using KetClass.Model;
using KetClass.View.Disciplinas;
using KetClass.View.Turmas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetClass.View.Shared
{
    public partial class SelecionaTurmaDisciplina : Form
    {
        public TurmaModel TurmaSel = null;
        public DisciplinaModel DisciplinaSel = null;

        public SelecionaTurmaDisciplina()
        {
            InitializeComponent();
            pesDisciplina.Crud = new DisciplinaView();
            pesTurma.Crud = new TurmaView();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TurmaSel = null;
            DisciplinaSel = null;
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (pesDisciplina.Objeto == null || pesTurma.Objeto == null)
            {
                MessageBox.Show("Favor selecionar a turma e a disciplina!", "ERA Class", MessageBoxButtons.OK);
                return;
            }

            TurmaSel = (TurmaModel)pesTurma.Objeto;
            DisciplinaSel = (DisciplinaModel)pesDisciplina.Objeto;
            this.Close();
        }

        private void SelecionaTurmaDisciplina_Shown(object sender, EventArgs e)
        {
            pesTurma.Clear();
            pesDisciplina.Clear();
            pesTurma.Focus();
            int materiaUsuario = AutenticacaoController.getInstance().MateriaUsuario();
            if (materiaUsuario > 0)
            {
                DisciplinaModel disc = KCContext.getInstance().Disciplinas.Find(materiaUsuario);
                if (disc != null)
                {
                    pesDisciplina.SetObjeto(disc);
                    pesDisciplina.ReadOnly = true;
                }
            }
        }
    }
}
