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
            ucAluno.Nome = "Aluno";
            ucMae.Nome = "Mãe";
            ucPai.Nome = "Pai";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            ucAluno.Salvar();
            ucPai.Salvar();
            ucMae.Salvar();
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
            model.Aluno = ucAluno.model;
            model.Pai = ucPai.model;
            model.Mae = ucMae.model;
            if (rbtMasculino.Checked)
            {
                model.Sexo = "M";
            }
            else
            {
                model.Sexo = "F";
            }
            model.Codigo = tbxCodigo.Text;
        }

        public void MapearTela()
        {
            if (baseEdit.estado == Data.Estado.Criando)
            {
                PessoaModel aluno = new PessoaModel();
                ucAluno.baseEdit.model = aluno;
                ucAluno.baseEdit.estado = Data.Estado.Criando;
                PessoaModel pai = new PessoaModel();
                ucPai.baseEdit.model = pai;
                ucPai.baseEdit.estado = Data.Estado.Criando;
                PessoaModel mae = new PessoaModel();
                ucMae.baseEdit.model = mae;
                ucMae.baseEdit.estado = Data.Estado.Criando;
                ucAluno.Clear();
                ucPai.Clear();
                ucMae.Clear();
                tbxCodigo.Clear();
                rbtMasculino.Checked = true;
            }
            else
            {
                ucAluno.baseEdit.model = model.Aluno;
                ucAluno.baseEdit.estado = Data.Estado.Editando;
                ucPai.baseEdit.model = model.Pai;
                ucPai.baseEdit.estado = Data.Estado.Editando;
                ucMae.baseEdit.model = model.Mae;
                ucMae.baseEdit.estado = Data.Estado.Editando;
                if (model.Sexo.Equals("M"))
                {
                    rbtMasculino.Checked = true;
                }
                else
                {
                    rbtFeminino.Checked = true;
                }
                tbxCodigo.Text = model.Codigo;
            }
        }

        public void Fechar()
        {
            this.Close();
        }

        private void AlunoEdit_Shown(object sender, EventArgs e)
        {
            MapearTela();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
