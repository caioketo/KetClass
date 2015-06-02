using KetClass.Model;
using KetClass.View.Base;
using KetClass.View.Turmas;
using KetClass.View.Unidades;
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
            ucMae.SetPai();
            ucPai.SetPai();

            
            pesTurma.Crud = new TurmaView();
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
            model.DataMatricula = dtpMatricula.Value;
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
            model.Numero = Convert.ToInt32(tbxNumero.Text);
            model.Turma = (TurmaModel)pesTurma.Objeto;
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
                tbxNumero.Clear();
                pesTurma.Clear();
            }
            else
            {
                ucAluno.baseEdit.model = model.Aluno;
                ucAluno.baseEdit.estado = Data.Estado.Editando;
                ucAluno.MapearTela();
                ucPai.baseEdit.model = model.Pai;
                ucPai.baseEdit.estado = Data.Estado.Editando;
                ucPai.MapearTela();
                ucMae.baseEdit.model = model.Mae;
                ucMae.baseEdit.estado = Data.Estado.Editando;
                ucMae.MapearTela();
                if (model.Sexo.Equals("M"))
                {
                    rbtMasculino.Checked = true;
                }
                else
                {
                    rbtFeminino.Checked = true;
                }
                tbxCodigo.Text = model.Codigo;
                tbxNumero.Text = model.Numero.ToString();
                pesTurma.SetObjeto(model.Turma);
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

        private void AlunoEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SelectNextControl(Utils.Util.FindFocusedControl(this), true, true, true, true);
            }
        }
    }
}
