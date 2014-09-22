using KetClass.Data;
using KetClass.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetClass.Controller
{
    public class UnidadeController : IController<UnidadeModel>
    {
        private KCContext context = KCContext.getInstance();

        public List<UnidadeModel> Index()
        {
            return context.Unidades.Where(a => !a.DataExclusao.HasValue).ToList();
        }

        public UnidadeModel Details(int id)
        {
            return context.Unidades.Where(a => a.Id == id).FirstOrDefault();
        }

        public UnidadeModel Create(UnidadeModel unidade)
        {
            unidade.DataAlteracao = DateTime.Now;
            unidade.DataCriacao = DateTime.Now;
            unidade = context.Unidades.Add(unidade);
            context.SaveChanges();
            return unidade;
        }

        public void Edit(UnidadeModel unidade)
        {
            unidade.DataAlteracao = DateTime.Now;
            context.Entry(unidade).State = EntityState.Modified;
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            try
            {
                UnidadeModel unidade = context.Unidades.Find(id);
                if (unidade == null)
                {
                    return false;
                }
                context.Unidades.Remove(unidade);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public List<UnidadeModel> Filter(string text)
        {
            return context.Unidades.Where(a => !a.DataExclusao.HasValue && a.Descricao.Contains(text)).ToList();
        }


        public List<System.Windows.Forms.DataGridViewColumn> Columns()
        {
            List<System.Windows.Forms.DataGridViewColumn> columns = new List<System.Windows.Forms.DataGridViewColumn>();
            columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
            {
                HeaderText = "Descrição",
                DataPropertyName = "Descricao",
                Name = "Descricao",
                DefaultCellStyle = new DataGridViewCellStyle()
            });

            columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
            {
                HeaderText = "Número",
                DataPropertyName = "Numero",
                Name = "Numero",
                DefaultCellStyle = new DataGridViewCellStyle()
            });

            return columns;
        }
    }
}
