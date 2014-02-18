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

        public void Config()
        {
            grid.AutoGenerateColumns = false;
            grid.Columns.Clear();
            foreach (DataGridViewColumn col in controller.Columns())
            {
                grid.Columns.Add(col);
            }
        }

        public BaseView(IController<T> _controller, DataGridView _grid, BaseEdit<T> _edit)
        {
            this.controller = _controller;
            this.grid = _grid;
            this.edit = _edit;
            this.edit.controller = this.controller;
            Config();
        }


        public void Index()
        {
            grid.DataSource = controller.Index();
        }

        public void Filter(string text)
        {
            List<T> lista = controller.Filter(text);
            if (lista.Count > 0)
            {
                grid.DataSource = lista;
            }
            else
            {
                grid.DataSource = new List<T>();
            }
        }

        public void Detail()
        {
            if (grid.SelectedRows.Count <= 0)
            {
                return;
            }
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
            if (grid.SelectedRows.Count <= 0)
            {
                return;
            }
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
