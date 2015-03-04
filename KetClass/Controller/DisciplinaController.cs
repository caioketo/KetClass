using KetClass.Data;
using KetClass.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Controller
{
    class DisciplinaController : IController<DisciplinaModel>
    {
        private KCContext context = KCContext.getInstance();

        public List<DisciplinaModel> Index()
        {
            return context.Disciplinas.Where(a => !a.DataExclusao.HasValue).ToList();
        }

        public DisciplinaModel Details(int id)
        {
            return context.Disciplinas.Where(a => a.Id == id).FirstOrDefault();
        }

        public DisciplinaModel Create(DisciplinaModel disciplina)
        {
            disciplina.DataAlteracao = DateTime.Now;
            disciplina.DataCriacao = DateTime.Now;
            disciplina = context.Disciplinas.Add(disciplina);
            context.SaveChanges();
            return disciplina;
        }

        public void Edit(DisciplinaModel disciplina)
        {
            disciplina.DataAlteracao = DateTime.Now;
            context.Entry(disciplina).State = EntityState.Modified;
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            try
            {
                DisciplinaModel disciplina = context.Disciplinas.Find(id);
                if (disciplina == null)
                {
                    return false;
                }
                context.Disciplinas.Remove(disciplina);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public List<DisciplinaModel> Filter(string text)
        {
            return context.Disciplinas.Where(a => !a.DataExclusao.HasValue && a.ToString().Contains(text)).ToList();
        }


        public List<System.Windows.Forms.DataGridViewColumn> Columns()
        {
            List<System.Windows.Forms.DataGridViewColumn> columns = new List<System.Windows.Forms.DataGridViewColumn>();

            return columns;
        }

    }
}
