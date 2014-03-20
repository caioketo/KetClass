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

namespace KetClass.View.Unidades
{
    public partial class UnidadeEdit : Form, IEdit
    {
        public UnidadeEdit()
        {
            InitializeComponent();
        }

        public BaseEdit<UnidadeModel> baseEdit = new BaseEdit<UnidadeModel>();

        private UnidadeModel model
        {
            get
            {
                return baseEdit.model;
            }
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
            model.Numero = Convert.ToInt32(tbxNumero.Text);
            model.Descricao = tbxDescricao.Text;
        }

        public void MapearTela()
        {
            if (baseEdit.estado != Data.Estado.Criando)
            {
                tbxNumero.Text = model.Numero.ToString();
                tbxDescricao.Text = model.Descricao;
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

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Fechar();
        }
    }
}
