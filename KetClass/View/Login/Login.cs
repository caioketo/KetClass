using KetClass.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetClass.View.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (AutenticacaoController.getInstance().VerificaLogin(tbxLogin.Text, tbxSenha.Text, true))
            {
                Close();
            }
            else
            {
                tbxSenha.Clear();
                tbxSenha.Focus();
                MessageBox.Show("Usuário/Senha incorretos!");
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SelectNextControl(Utils.Util.FindFocusedControl(this), true, true, true, true);
            }
        }
    }
}
