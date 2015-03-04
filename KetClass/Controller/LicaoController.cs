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
    public class LicaoController : IController<LicaoModel>
    {
        private KCContext context = KCContext.getInstance();

        public List<LicaoModel> Index()
        {
            return context.Licoes.Where(a => !a.DataExclusao.HasValue).ToList();
        }

        public LicaoModel Details(int id)
        {
            return context.Licoes.Where(a => a.Id == id).FirstOrDefault();
        }

        public LicaoModel Create(LicaoModel licao)
        {
            licao.DataAlteracao = DateTime.Now;
            licao.DataCriacao = DateTime.Now;
            licao = context.Licoes.Add(licao);
            context.SaveChanges();
            return licao;
        }

        public void Edit(LicaoModel licao)
        {
            licao.DataAlteracao = DateTime.Now;
            context.Entry(licao).State = EntityState.Modified;
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            try
            {
                LicaoModel licao = context.Licoes.Find(id);
                if (licao == null)
                {
                    return false;
                }
                context.Licoes.Remove(licao);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public List<LicaoModel> Filter(string text)
        {
            return context.Licoes.Where(a => !a.DataExclusao.HasValue && a.Conteudo.Contains(text)).ToList();
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
                HeaderText = "Conteudo",
                DataPropertyName = "Conteudo",
                Name = "ConteudoC",
                DefaultCellStyle = new DataGridViewCellStyle()
            });

            return columns;
        }
    }
}
