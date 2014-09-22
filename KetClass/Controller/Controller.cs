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
    public class Controller<T> : IController<T> where T : BaseEntity
    {
        public KCContext context = KCContext.getInstance();
        public DbSet<T> dbset;
        public ICRUD crud;

        public List<T> Index()
        {
            return dbset.Where(a => !a.DataExclusao.HasValue).ToList();
        }


        public T Details(int id)
        {
            return dbset.Where(a => a.Id == id).FirstOrDefault();
        }

        public T Create(T t)
        {
            t.DataAlteracao = DateTime.Now;
            t.DataCriacao = DateTime.Now;
            t = dbset.Add(t);
            context.SaveChanges();
            return t;
        }

        public void Edit(T t)
        {
            t.DataAlteracao = DateTime.Now;
            context.Entry(t).State = EntityState.Modified;
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            try
            {
                T t = dbset.Find(id);
                if (t == null)
                {
                    return false;
                }
                dbset.Remove(t);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public List<T> Filter(System.Linq.Expressions.Expression<Func<T, bool>> expressao)
        {
            if (dbset.Where(expressao) == null)
            {
                return null;
            }
            return dbset.Where(expressao).ToList();
        }


        public List<T> Filter(string text)
        {
            return new List<T>();
        }

        public List<System.Windows.Forms.DataGridViewColumn> Columns()
        {
            return null;
        }
    }
}
