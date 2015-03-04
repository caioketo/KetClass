using KetClass.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class MatriculaModel : BaseEntity
    {
        public int AlunoId { get; set; }
        [ForeignKey("AlunoId")]
        public virtual AlunoModel Aluno { get; set; }
        public int TurmaId { get; set; }
        [ForeignKey("TurmaId")]
        public virtual TurmaModel Turma { get; set; }
        public int Numero { get; set; }
        public DateTime DataMatricula { get; set; }


        public virtual string AlunoNome
        {
            get
            {
                if (Aluno != null)
                {
                    return Aluno.AlunoNome;
                }
                else
                {
                    return "";
                }
            }
        }

        public virtual string TurmaDisplay
        {
            get
            {
                if (Turma != null)
                {
                    return Turma.Display;
                }
                else
                {
                    return "";
                }
            }
        }

        public string Display
        {
            get
            {
                return ToString();
            }
        }

        public override string ToString()
        {
            return Aluno.AlunoNome + " - " + Turma.Display;
        }

    }
}
