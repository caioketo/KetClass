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

namespace KetClass.View.Licao
{
    public partial class CreateLicao : Form
    {
        private TurmaController turmaController = new TurmaController();
        private DisciplinaController disciplinaController = new DisciplinaController();
        
        public CreateLicao()
        {
            InitializeComponent();

            cbxTurma.DataSource = turmaController.Index();
            cbxDisciplina.DataSource = disciplinaController.Index();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KCContext context = KCContext.getInstance();
            LicaoModel licao = new LicaoModel();
            licao.Sinc = false;
            licao.Conteudo = tbxConteudo.Text;
            licao.DataLicao = dtpData.Value;
            licao.DisciplinaId = ((DisciplinaModel)cbxDisciplina.SelectedValue).Id;
            licao.TurmaId = ((TurmaModel)cbxTurma.SelectedValue).Id;
            licao.DataAlteracao = DateTime.Now;
            licao.DataCriacao = DateTime.Now;
            licao = context.Licoes.Add(licao);
            context.SaveChanges();
            this.Close();
        }

        private void CreateLicao_Shown(object sender, EventArgs e)
        {
            dtpData.Value = DateTime.Now;
            int materiaUsuario = AutenticacaoController.getInstance().MateriaUsuario();
            if (materiaUsuario > 0)
            {
                DisciplinaModel disc = KCContext.getInstance().Disciplinas.Find(materiaUsuario);
                if (disc != null)
                {
                    for (int i = 0; i < cbxDisciplina.Items.Count; i++)
                    {
                        if (((DisciplinaModel)cbxDisciplina.Items[i]).Id == disc.Id)
                        {
                            cbxDisciplina.SelectedIndex = i;
                            cbxDisciplina.Enabled = false;
                            break;
                        }
                    }
                }
            }
        }

        private void CreateLicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SelectNextControl(Utils.Util.FindFocusedControl(this), true, true, true, true);
            }
        }
    }
}
