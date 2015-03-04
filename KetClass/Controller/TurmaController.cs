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
    class TurmaController : IController<TurmaModel>
    {
        private KCContext context = KCContext.getInstance();

        public List<TurmaModel> Index()
        {
            return context.Turmas.Where(a => !a.DataExclusao.HasValue).ToList();
        }

        public TurmaModel Details(int id)
        {
            return context.Turmas.Where(a => a.Id == id).FirstOrDefault();
        }

        public TurmaModel Create(TurmaModel turma)
        {
            turma.DataAlteracao = DateTime.Now;
            turma.DataCriacao = DateTime.Now;
            turma = context.Turmas.Add(turma);
            context.SaveChanges();
            return turma;
        }

        public void Edit(TurmaModel turma)
        {
            turma.DataAlteracao = DateTime.Now;
            context.Entry(turma).State = EntityState.Modified;
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            try
            {
                TurmaModel turma = context.Turmas.Find(id);
                if (turma == null)
                {
                    return false;
                }
                context.Turmas.Remove(turma);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public List<TurmaModel> Filter(string text)
        {
            return context.Turmas.Where(a => !a.DataExclusao.HasValue && a.ToString().Contains(text)).ToList();
        }


        public List<System.Windows.Forms.DataGridViewColumn> Columns()
        {
            List<System.Windows.Forms.DataGridViewColumn> columns = new List<System.Windows.Forms.DataGridViewColumn>();

            return columns;
        }
    }
}
