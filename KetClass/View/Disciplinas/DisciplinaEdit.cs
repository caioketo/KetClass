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

namespace KetClass.View.Disciplinas
{
    public partial class DisciplinaEdit : Form, IEdit
    {
        public BaseEdit<DisciplinaModel> baseEdit = new BaseEdit<DisciplinaModel>();

        private DisciplinaModel model
        {
            get
            {
                return baseEdit.model;
            }
        }

        public DisciplinaEdit()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Fechar();
        }

        private void DisciplinaEdit_Shown(object sender, EventArgs e)
        {
            MapearTela();
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
            model.Descricao = tbxDescricao.Text;
            model.Abreviatura = tbxAbreviatura.Text;
            model.NomeHistorico = tbxHistorico.Text;
        }

        public void MapearTela()
        {
            if (baseEdit.estado == Data.Estado.Criando)
            {
                tbxHistorico.Clear();
                tbxAbreviatura.Clear();
                tbxDescricao.Clear();
            }
            else
            {
                tbxAbreviatura.Text = model.Abreviatura;
                tbxDescricao.Text = model.Descricao;
                tbxHistorico.Text = model.NomeHistorico;
            }
        }

        public void Fechar()
        {
            this.Close();
        }
    }
}
