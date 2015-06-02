using KetClass.Model;
using KetClass.View.Base;
using KetClass.View.Cursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetClass.View.Turmas
{
    public partial class TurmaEdit : Form, IEdit
    {
        public BaseEdit<TurmaModel> baseEdit = new BaseEdit<TurmaModel>();

        private TurmaModel model
        {
            get
            {
                return baseEdit.model;
            }
        }


        public TurmaEdit()
        {
            InitializeComponent();
            pesCurso.Crud = new CursoView();
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
            model.Curso = (CursoModel)pesCurso.Objeto;
            model.Descricao = tbxDescricao.Text;
            model.Serie = Convert.ToInt32(tbxSerie.Text);
        }

        public void MapearTela()
        {
            if (baseEdit.estado == Data.Estado.Criando)
            {
                tbxSerie.Clear();
                tbxDescricao.Clear();
                pesCurso.Clear();
            }
            else
            {
                tbxDescricao.Text = model.Descricao;
                tbxSerie.Text = model.Serie.ToString();
                pesCurso.SetObjeto(model.Curso);
            }
        }

        public void Fechar()
        {
            this.Close();
        }

        private void TurmaEdit_Shown(object sender, EventArgs e)
        {
            MapearTela();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void TurmaEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SelectNextControl(Utils.Util.FindFocusedControl(this), true, true, true, true);
            }
        }
    }
}
