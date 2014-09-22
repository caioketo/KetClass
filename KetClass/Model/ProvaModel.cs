using KetClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class ProvaModel : BaseEntity
    {
        public DateTime DataProva { get; set; }
        public int Trimestre { get; set; }
        public int TurmaId { get; set; }
        public int DisciplinaId { get; set; }
        public bool Recuperacao { get; set; }
        public string Descricao { get; set; }
        public bool Sinc { get; set; }

        public override string ToString()
        {
            return Descricao;
        }

        public virtual DisciplinaModel Disciplina { get; set; }
        public virtual TurmaModel Turma { get; set; }

        public string DataFormatada
        {
            get
            {
                return DataProva.ToString("dd/MM/yyyy");
            }
        }

        public string DisciplinaDesc
        {
            get
            {
                return Disciplina.Descricao;
            }
        }

        public string TurmaDesc
        {
            get
            {
                return Turma.Display;
            }
        }
    }
}
