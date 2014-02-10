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
    public class AlunoController : IController<AlunoModel>
    {
        private KCContext context = new KCContext();

        public List<AlunoModel> Index()
        {
            return context.Alunos.Where(a => !a.DataExclusao.HasValue).ToList();
        }

        public AlunoModel Details(int id)
        {
            return context.Alunos.Where(a => a.Id == id).FirstOrDefault();
        }

        public AlunoModel Create(AlunoModel aluno)
        {
            aluno.DataAlteracao = DateTime.Now;
            aluno.DataCriacao = DateTime.Now;
            aluno = context.Alunos.Add(aluno);
            context.SaveChanges();
            return aluno;
        }

        public void Edit(AlunoModel aluno)
        {
            aluno.DataAlteracao = DateTime.Now;
            context.Entry(aluno).State = EntityState.Modified;
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            try
            {
                AlunoModel aluno = context.Alunos.Find(id);
                if (aluno == null)
                {
                    return false;
                }
                context.Alunos.Remove(aluno);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
