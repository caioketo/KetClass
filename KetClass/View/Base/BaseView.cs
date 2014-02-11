using KetClass.Data;
using KetClass.Model;
using KetClass.View.Alunos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetClass.View.Base
{
    public class BaseView<T> where T : BaseEntity, new() 
    {
        public BaseEdit<T> edit { get; set; }
        public DataGridView grid { get; set; }
        public IController<T> controller { get; set; }

        public void Index()
        {
            grid.DataSource = controller.Index();
        }

        public void Detail()
        {
            T model = (T)grid.SelectedRows[0].DataBoundItem;
            model = controller.Details(model.Id);
            edit.model = model;
            edit.estado = Estado.Editando;
        }

        public void Create()
        {
            T model = new T();
            edit.model = model;
            edit.estado = Estado.Criando;
        }

        public void Delete()
        {
            if (MessageBox.Show("Tem certeza?", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                T model = (T)grid.SelectedRows[0].DataBoundItem;
                if (controller.Delete(model.Id))
                {
                    Index();
                }
            }
        }
    }
}
