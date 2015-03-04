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

namespace KetClass.View.Licao
{
    public partial class LicaoView : Form
    {
        private BaseView<LicaoModel> baseView;
        private Controller<LicaoModel> controller = new Controller<LicaoModel>();

        public LicaoView()
        {
            InitializeComponent();
            crud.btnEditarClick += btnEditar_Click;
            crud.btnInserirClick += btnInserir_Click;
            crud.btnExcluirClick += btnExcluir_Click;
            crud.btnSelecionarClick += btnSelecionar_Click;
            crud.tbxPesquisaChange += tbxPesquisa_TextChanged;
            controller.dbset = controller.context.Licoes;
            baseView = new BaseView<LicaoModel>(controller, crud.dgvCRUD, null, "Licao");
            baseView.Index();
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            using (CreateLicao c = new CreateLicao())
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
            baseView.Filter(controller.Filter(l => l.Conteudo.Contains(crud.tbxPesquisa.Text)).ToList());
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
