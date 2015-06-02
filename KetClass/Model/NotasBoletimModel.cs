using KetClass.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class NotasBoletimModel : BaseEntity
    {
        public int AlunoId { get; set; }
        [ForeignKey("AlunoId")]
        public virtual AlunoModel Aluno { get; set; }
        public int DisciplinaId { get; set; }
        [ForeignKey("DisciplinaId")]
        public virtual DisciplinaModel Disciplina { get; set; }

        [NotMapped]
        public string DisciplinaDesc
        {
            get
            {
                if (Disciplina == null)
                {
                    return "";
                }
                return Disciplina.Descricao;
            }
        }
        public double Nota { get; set; }
        public double Rec { get; set; }
        public double Media { get; set; }
        public int Faltas { get; set; }
        public int Trimestre { get; set; }
    }
}
