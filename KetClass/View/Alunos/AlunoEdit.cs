using KetClass.Model;
using KetClass.View.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetClass.View.Alunos
{
    public partial class AlunoEdit : Form, IEdit
    {
        public BaseEdit<AlunoModel> baseEdit = new BaseEdit<AlunoModel>();

        private AlunoModel model
        {
            get
            {
                return baseEdit.model;
            }
        }

        public AlunoEdit()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Fechar();
        }

        public void Salvar()
        {
            Mapear();
            if (baseEdit.Salvar())
            {
                Fechar();
            }
        }

        public void Mapear()
        {
            model.Aluno.Nome = tbxNomeAluno.Text;
            model.Aluno.Telefone = tbxTelefoneAluno.Text;
            model.Pai.Nome = tbxNomePai.Text;
            model.Pai.Telefone = tbxTelefonePai.Text;
            model.Mae.Nome = tbxNomeMae.Text;
            model.Mae.Telefone = tbxTelefoneMae.Text;
        }

        public void MapearTela()
        {
            tbxNomeAluno.Text = model.Aluno.Nome;
            model.Aluno.Telefone = tbxTelefoneAluno.Text;
            model.Pai.Nome = tbxNomePai.Text;
            model.Pai.Telefone = tbxTelefonePai.Text;
            model.Mae.Nome = tbxNomeMae.Text;
            model.Mae.Telefone = tbxTelefoneMae.Text;
        }

        public void Fechar()
        {
            this.Close();
        }

        private void AlunoEdit_Shown(object sender, EventArgs e)
        {
            MapearTela();
        }
    }
}
