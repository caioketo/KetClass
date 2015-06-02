using KetClass.Controller;
using KetClass.Utils;
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
    public partial class CreateRole : Form
    {
        public List<Permissao> Permissoes = new List<Permissao>();
        public List<Permissao> PermissoesRole = new List<Permissao>();
        AutenticacaoController controller = new AutenticacaoController();
        public CreateRole()
        {
            Permissoes = Util.LoadPermissoes();
            InitializeComponent();
            cbxPermissoes.DataSource = Permissoes;
            dgvPermissoes.DataSource = PermissoesRole;

            dgvPermissoes.AutoGenerateColumns = false;
            dgvPermissoes.Columns.Clear();
            dgvPermissoes.Columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
            {
                HeaderText = "Nome",
                DataPropertyName = "Nome",
                Name = "NomeC",
                DefaultCellStyle = new DataGridViewCellStyle()
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PermissoesRole.Contains(Permissoes[cbxPermissoes.SelectedIndex]))
                return;
            PermissoesRole.Add(Permissoes[cbxPermissoes.SelectedIndex]);
            dgvPermissoes.DataSource = null;
            dgvPermissoes.DataSource = PermissoesRole;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.AddRole(PermissoesRole);
        }
    }
}
