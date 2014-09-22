using KetClass.Controller;
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

namespace KetClass.View.Provas
{
    public partial class ProvaView : Form
    {
        private BaseView<ProvaModel> baseView;
        private Controller<ProvaModel> controller = new Controller<ProvaModel>();
        public ProvaView()
        {
            InitializeComponent();
            crud.btnEditarClick += btnEditar_Click;
            crud.btnInserirClick += btnInserir_Click;
            crud.btnExcluirClick += btnExcluir_Click;
            crud.btnSelecionarClick += btnSelecionar_Click;
            crud.tbxPesquisaChange += tbxPesquisa_TextChanged;
            controller.dbset = controller.context.Provas;
            baseView = new BaseView<ProvaModel>(controller, crud.dgvCRUD, null, "Prova");
            baseView.Index();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            using (CriarProva c = new CriarProva())
            {
                c.ShowDialog();
            }
            baseView.Index();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            baseView.Delete();
            baseView.Index();
        }

        private void tbxPesquisa_TextChanged(object sender, EventArgs e)
        {
            baseView.Filter(controller.Filter(p => p.Descricao.Contains(crud.tbxPesquisa.Text)).ToList()); ;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
