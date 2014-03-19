using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KetClass.Data;

namespace KetClass.View.Shared
{
    public partial class UCPesquisa : UserControl
    {
        public delegate BaseEntity PesquisaHandler(object sender, EventArgs e);
        public event PesquisaHandler Pesquisar;
        public BaseEntity Objeto = null;

        public UCPesquisa()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Objeto = null;
            tbxPesquisa.Clear();
            tbxPesquisa.ReadOnly = false;
            tbxPesquisa.BackColor = Color.White;
        }

        private void tbxPesquisa_Leave(object sender, EventArgs e)
        {
            if (Pesquisar != null)
            {
                BaseEntity retorno = null;
                if ((retorno = Pesquisar(tbxPesquisa, e)) != null)
                {
                    Objeto = retorno;
                    tbxPesquisa.ReadOnly = true;
                    tbxPesquisa.BackColor = Color.LightGray;
                    tbxPesquisa.Text = Objeto.ToString();
                }
            }
        }

        public void setObjeto(BaseEntity objeto)
        {
            if (objeto == null)
            {
                return;
            }
            Objeto = objeto;
            tbxPesquisa.ReadOnly = true;
            tbxPesquisa.BackColor = Color.LightGray;
            tbxPesquisa.Text = Objeto.ToString();
        }
    }
}
