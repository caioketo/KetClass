using KetClass.Model;
using KetClass.View.Alunos;
using KetClass.View.Base;
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

namespace KetClass.View.Matriculas
{
    public partial class MatriculaEdit : Form, IEdit
    {
        public BaseEdit<MatriculaModel> baseEdit = new BaseEdit<MatriculaModel>();

        private MatriculaModel model
        {
            get
            {
                return baseEdit.model;
            }
        }

        public MatriculaEdit()
        {
            InitializeComponent();
            pesAluno.Crud = new AlunoView();
            pesTurma.Crud = new TurmaView();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
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
            model.Turma = (TurmaModel)pesTurma.Objeto;
            model.Aluno = (AlunoModel)pesAluno.Objeto;
            model.DataMatricula = dtpMatricula.Value;
        }

        public void MapearTela()
        {
            if (baseEdit.estado == Data.Estado.Criando)
            {
                dtpMatricula.Value = DateTime.Now;
                pesTurma.Clear();
                pesAluno.Clear();
            }
            else
            {
                dtpMatricula.Value = model.DataMatricula;
                pesTurma.SetObjeto(model.Turma);
                pesAluno.SetObjeto(model.Aluno);
            }
        }

        public void Fechar()
        {
            this.Close();
        }

        private void MatriculaEdit_Shown(object sender, EventArgs e)
        {
            MapearTela();
        }

        private void MatriculaEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SelectNextControl(Utils.Util.FindFocusedControl(this), true, true, true, true);
            }
        }
    }
}
