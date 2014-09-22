using KetClass.Data;
using System.ComponentModel.DataAnnotations.Schema;
7using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class NotaModel : BaseEntity
    {
        public int TurmaId { get; set; }
        [ForeignKey("TurmaId")]
        public virtual TurmaModel Turma { get; set; }

        public int DisciplinaId { get; set; }
        [ForeignKey("DisciplinaId")]
        public virtual DisciplinaModel Disciplina { get; set; }

        public int Numero { get; set; }
        public double Nota { get; set; }
        public int Faltas { get; set; }
        public int AulasDadas { get; set; }
        public bool Recupercao { get; set; }
    }
}
