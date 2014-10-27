using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class NotasBoletimModel
    {
        public AlunoModel Aluno { get; set; }
        public DisciplinaModel Disciplina { get; set; }
        public double Nota { get; set; }
        public double Rec { get; set; }
        public double Media { get; set; }
        public int Faltas { get; set; }
        public int Trimestre { get; set; }
    }
}
