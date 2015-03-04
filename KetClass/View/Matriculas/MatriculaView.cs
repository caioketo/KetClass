using KetClass.Controller;
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

namespace KetClass.View.Matriculas
{
    public partial class MatriculaView : Form, ICRUD
    {
        private BaseView<MatriculaModel> baseView;
        private Controller<MatriculaModel> controller = new Controller<MatriculaModel>();
        private MatriculaEdit edit = new MatriculaEdit();

        public MatriculaView()
        {
            InitializeComponent();
            crud.btnEditarClick += btnEditar_Click;
            crud.btnInserirClick += btnInserir_Click;
            crud.btnExcluirClick += btnExcluir_Click;
            crud.btnSelecionarClick += btnSelecionar_Click;
            crud.tbxPesquisaChange += tbxPesquisa_TextChanged;
            controller.dbset = controller.context.Matriculas;
            baseView = new BaseView<MatriculaModel>(controller, crud.dgvCRUD, edit.baseEdit, "Matrícula");
            baseView.orderIndex = orderIndex;
            baseView.Index();
        }

        public void orderIndex()
        {
            baseView.grid.DataSource = controller.Index().OrderBy(m => m.Turma.Serie)
                .ThenBy(m => m.Turma.Descricao).ThenBy(m => m.Aluno.Aluno.Nome).ToList();
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
            baseView.Filter(controller.Filter(p => p.Aluno.Aluno.Nome.Contains(crud.tbxPesquisa.Text)).ToList());
        }

        public BaseEntity Pesquisar(string texto = "")
        {
            crud.btnSelecionar.Visible = true;
            crud.tbxPesquisa.Text = texto;
            if (crud.dgvCRUD.Rows.Count == 1)
            {
                return (BaseEntity)crud.dgvCRUD.Rows[0].DataBoundItem;
            }
            ShowDialog();
            return (BaseEntity)crud.dgvCRUD.SelectedRows[0].DataBoundItem;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
