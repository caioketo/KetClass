using KetClass.Controller;
using KetClass.Model;
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
    public partial class CreateUser : Form
    {
        Controller<UserModel> controller = new Controller<UserModel>();
        List<RoleModel> roles = new List<RoleModel>();
        public CreateUser()
        {
            InitializeComponent();
            controller.dbset = controller.context.Users;
            cmbRoles.DataSource = controller.context.Roles.Where(r => !r.DataExclusao.HasValue).ToList();
            cmbRoles.DisplayMember = "Descricao";
            dgvRoles.AutoGenerateColumns = false;
            dgvRoles.Columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
            {
                HeaderText = "Descricao",
                DataPropertyName = "Descricao",
                Name = "DescricaoC",
                DefaultCellStyle = new DataGridViewCellStyle()
            });
            dgvRoles.DataSource = roles;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (!roles.Contains(cmbRoles.SelectedValue))
            {
                roles.Add((RoleModel)cmbRoles.SelectedValue);
                dgvRoles.DataSource = null;
                dgvRoles.DataSource = roles;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            roles.Remove((RoleModel)dgvRoles.SelectedRows[0].DataBoundItem);
            dgvRoles.DataSource = null;
            dgvRoles.DataSource = roles;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserModel usuario = new UserModel();
            usuario.Cargo = tbxCargo.Text;
            usuario.Login = tbxLogin.Text;
            usuario.Nome = tbxNome.Text;
            usuario.Password = tbxSenha.Text;
            usuario.Roles = roles;
            controller.Create(usuario);
            Close();
        }
    }
}
