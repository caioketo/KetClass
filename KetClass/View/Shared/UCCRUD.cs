using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetClass.View.Shared
{
    public partial class UCCRUD : UserControl
    {
        public delegate void ButtonClick(object sender, EventArgs args);
        public ButtonClick btnSelecionarClick;
        public ButtonClick btnExcluirClick;
        public ButtonClick btnEditarClick;
        public ButtonClick btnInserirClick;
        public ButtonClick tbxPesquisaChange;

        public UCCRUD()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (btnSelecionarClick != null)
            {
                btnSelecionarClick(sender, e);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (btnExcluirClick != null)
            {
                btnExcluirClick(sender, e);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditarClick != null)
            {
                btnEditarClick(sender, e);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (btnInserirClick != null)
            {
                btnInserirClick(sender, e);
            }
        }

        private void tbxPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (tbxPesquisaChange != null)
            {
                tbxPesquisaChange(sender, e);
            }
        }

    }
}
