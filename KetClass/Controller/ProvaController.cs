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
    public class ProvaController : IController<ProvaModel>
    {
        private KCContext context = KCContext.getInstance();

        public List<ProvaModel> Index()
        {
            return context.Provas.Where(a => !a.DataExclusao.HasValue).ToList();
        }

        public ProvaModel Details(int id)
        {
            return context.Provas.Where(a => a.Id == id).FirstOrDefault();
        }

        public ProvaModel Create(ProvaModel prova)
        {
            prova.DataAlteracao = DateTime.Now;
            prova.DataCriacao = DateTime.Now;
            prova = context.Provas.Add(prova);
            context.SaveChanges();
            return prova;
        }

        public void Edit(ProvaModel prova)
        {
            prova.DataAlteracao = DateTime.Now;
            context.Entry(prova).State = EntityState.Modified;
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            try
            {
                ProvaModel prova = context.Provas.Find(id);
                if (prova == null)
                {
                    return false;
                }
                context.Provas.Remove(prova);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public List<ProvaModel> Filter(string text)
        {
            return context.Provas.Where(a => !a.DataExclusao.HasValue && a.Descricao.Contains(text)).ToList();
        }


        public List<System.Windows.Forms.DataGridViewColumn> Columns()
        {
            List<System.Windows.Forms.DataGridViewColumn> columns = new List<System.Windows.Forms.DataGridViewColumn>();
            columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
            {
                HeaderText = "Data",
                DataPropertyName = "DataFormatada",
                Name = "DataC",
                DefaultCellStyle = new DataGridViewCellStyle()
            });
            columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
            {
                HeaderText = "Disciplina",
                DataPropertyName = "DisciplinaDesc",
                Name = "DisciplinaC",
                DefaultCellStyle = new DataGridViewCellStyle()
            });
            columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
            {
                HeaderText = "Turma",
                DataPropertyName = "TurmaDesc",
                Name = "TurmaC",
                DefaultCellStyle = new DataGridViewCellStyle()
            });
            columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
            {
                HeaderText = "Descricao",
                DataPropertyName = "Descricao",
                Name = "DescricaoC",
                DefaultCellStyle = new DataGridViewCellStyle()
            });

            return columns;
        }
    }
}
