using KetClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class CursoModel : BaseEntity
    {
        public string Descricao { get; set; }
        public PeriodoModel Periodo { get; set; }
        public AnoModel Ano { get; set; }
        public UnidadeModel Unidade { get; set; }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
