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
    public class PessoaController : IController<PessoaModel>
    {
        private KCContext context = new KCContext();

        public List<PessoaModel> Index()
        {
            return context.Pessoas.Where(p => !p.DataExclusao.HasValue).ToList();
        }

        public PessoaModel Details(int id)
        {
            return context.Pessoas.Where(p => p.Id == id).FirstOrDefault();
        }

        public PessoaModel Create(PessoaModel pessoa)
        {
            pessoa.DataAlteracao = DateTime.Now;
            pessoa.DataCriacao = DateTime.Now;
            pessoa = context.Pessoas.Add(pessoa);
            context.SaveChanges();
            return pessoa;
        }

        public void Edit(PessoaModel pessoa)
        {
            pessoa.DataAlteracao = DateTime.Now;
            context.Entry(pessoa).State = EntityState.Modified;
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            try
            {
                PessoaModel pessoa = context.Pessoas.Find(id);
                if (pessoa == null)
                {
                    return false;
                }
                context.Pessoas.Remove(pessoa);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public List<PessoaModel> Filter(string text)
        {
            return context.Pessoas.Where(p => !p.DataExclusao.HasValue && p.Nome.Contains(text)).ToList();
        }


        public List<System.Windows.Forms.DataGridViewColumn> Columns()
        {
            List<System.Windows.Forms.DataGridViewColumn> columns = new List<System.Windows.Forms.DataGridViewColumn>();
            return columns;
        }
    }
}
