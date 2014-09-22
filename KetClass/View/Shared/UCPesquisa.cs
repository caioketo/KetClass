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
        public BaseEntity Objeto = null;
        public ICRUD Crud;

        public UCPesquisa()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void tbxPesquisa_Leave(object sender, EventArgs e)
        {
            if (Crud == null || Objeto != null || String.IsNullOrEmpty(tbxPesquisa.Text))
            {
                return;
            }
            BaseEntity retorno = Crud.Pesquisar(tbxPesquisa.Text);
            if (retorno != null)
            {
                Objeto = retorno;
                tbxPesquisa.ReadOnly = true;
                tbxPesquisa.BackColor = Color.LightGray;
                tbxPesquisa.Text = Objeto.ToString();
            }
        }

        public void SetObjeto(BaseEntity objeto)
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

        public void Clear()
        {
            Objeto = null;
            tbxPesquisa.Clear();
            tbxPesquisa.ReadOnly = false;
            tbxPesquisa.BackColor = Color.White;
            tbxPesquisa.Focus();
        }
    }
}
