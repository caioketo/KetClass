﻿using KetClass.Controller;
using KetClass.Data;
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
    public partial class UnidadeView : Form, ICRUD
    {
        private BaseView<UnidadeModel> baseView;
        private UnidadeController controller = new UnidadeController();
        private UnidadeEdit edit = new UnidadeEdit();

        public UnidadeView()
        {
            InitializeComponent();
            crud.btnEditarClick += btnEditar_Click;
            crud.btnInserirClick += btnInserir_Click;
            crud.btnExcluirClick += btnExcluir_Click;
            crud.btnSelecionarClick += btnSelecionar_Click;
            baseView = new BaseView<UnidadeModel>(controller, crud.dgvCRUD, edit.baseEdit);
            baseView.Index();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            baseView.Create();
            edit.ShowDialog();
            baseView.Index();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            baseView.Detail();
            edit.ShowDialog();
            baseView.Index();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            baseView.Delete();
            baseView.Index();
        }

        private void tbxPesquisa_TextChanged(object sender, EventArgs e)
        {
            baseView.Filter(crud.tbxPesquisa.Text);
        }

        public BaseEntity Pesquisar(string texto = "")
        {
            crud.btnSelecionar.Visible = true;
            crud.tbxPesquisa.Text = texto;
            ShowDialog();
            if (crud.dgvCRUD.SelectedRows.Count > 0)
            {
                return (BaseEntity)crud.dgvCRUD.SelectedRows[0].DataBoundItem;
            }
            else
            {
                return null;
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UnidadeView_Shown(object sender, EventArgs e)
        {
            if (!crud.tbxPesquisa.Text.Equals(""))
            {
                tbxPesquisa_TextChanged(crud.tbxPesquisa, null);
            }
        }
    }
}