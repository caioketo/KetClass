using KetClass.Controller;
using KetClass.Data;
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
    public partial class ViewRoles : Form
    {
        Controller<RoleModel> controller = new Controller<RoleModel>();
        public ViewRoles()
        {
            controller.dbset = controller.context.Roles;
            InitializeComponent();
            dgvRoles.AutoGenerateColumns = false;
            dgvRoles.Columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
            {
                HeaderText = "Descricao",
                DataPropertyName = "Descricao",
                Name = "DescricaoC",
                DefaultCellStyle = new DataGridViewCellStyle()
            });
            dgvRoles.DataSource = controller.context.Roles.Where(r => r.DataExclusao == null).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoleModel role = (RoleModel)dgvRoles.SelectedRows[0].DataBoundItem;
            controller.Delete(role.Id);

            dgvRoles.DataSource = null;
            dgvRoles.DataSource = controller.context.Roles.Where(r => r.DataExclusao == null).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
