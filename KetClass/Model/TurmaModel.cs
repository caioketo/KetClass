using KetClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class TurmaModel : BaseEntity
    {
        public string Descricao { get; set; }
        public CursoModel Curso { get; set; }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
