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

namespace KetClass.View.Cursos
{
    public partial class CursoView : Form, ICRUD
    {
        private BaseView<CursoModel> baseView;
        private Controller<CursoModel> controller = new Controller<CursoModel>();
        private CriarCurso edit = new CriarCurso();
        public CursoView()
        {
            InitializeComponent();
            crud.btnEditarClick += btnEditar_Click;
            crud.btnInserirClick += btnInserir_Click;
            crud.btnExcluirClick += btnExcluir_Click;
            crud.btnSelecionarClick += btnSelecionar_Click;
            crud.tbxPesquisaChange += tbxPesquisa_TextChanged;
            controller.dbset = controller.context.Cursos;
            baseView = new BaseView<CursoModel>(controller, crud.dgvCRUD, edit.baseEdit, "Curso");
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
            DataGridViewCell cell = crud.dgvCRUD.CurrentCell;
            int rowIndex = cell.RowIndex;
            int columnIndex = cell.ColumnIndex;
            baseView.Detail();
            edit.ShowDialog();
            baseView.Index();
            crud.dgvCRUD.CurrentCell = crud.dgvCRUD.Rows[rowIndex].Cells[columnIndex];
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            baseView.Delete();
            baseView.Index();
        }

        private void tbxPesquisa_TextChanged(object sender, EventArgs e)
        {
            baseView.Filter(controller.Filter(c => c.Descricao.Contains(crud.tbxPesquisa.Text)).ToList()); ;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public BaseEntity Pesquisar(string texto = "")
        {
            crud.btnSelecionar.Visible = true;
            crud.tbxPesquisa.Text = texto;
            ShowDialog();
            return (BaseEntity)crud.dgvCRUD.SelectedRows[0].DataBoundItem;
        }
    }
}
