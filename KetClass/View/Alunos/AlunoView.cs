﻿using KetClass.Controller;
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
    public partial class AlunoView : Form
    {
        private BaseView<AlunoModel> baseView = new BaseView<AlunoModel>();
        private AlunoController controller = new AlunoController();
        private AlunoEdit edit = new AlunoEdit();

        public AlunoView()
        {
            baseView.edit = edit.baseEdit;
            baseView.controller = this.controller;
            baseView.grid = dgvAlunos;
            InitializeComponent();
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
    }
}
