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

namespace KetClass.View.Notas
{
    public partial class NotasView : Form
    {
        private BaseView<NotaModel> baseView;
        private Controller<NotaModel> controller = new Controller<NotaModel>();
        private BaseEdit<NotaModel> baseEdit;
        public NotasView()
        {
            InitializeComponent();
            baseEdit = new BaseEdit<NotaModel>();
            crud.tbxPesquisaChange += tbxPesquisa_TextChanged;
            controller.dbset = controller.context.Notas;
            baseView = new BaseView<NotaModel>(controller, crud.dgvCRUD, baseEdit, "Notas");
            baseView.Index();
        }

        private void tbxPesquisa_TextChanged(object sender, EventArgs e)
        {
            //baseView.Filter(controller.Filter(p => p.Descricao.Contains(crud.tbxPesquisa.Text) ||
                //SqlFunctions.StringConvert((double)p.Serie).Contains(crud.tbxPesquisa.Text)).ToList());
        }
    }
}
