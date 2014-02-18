using KetClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class CidadeModel : BaseEntity
    {
        public UFModel UF { get; set; }
        public string Descricao { get; set; }
    }
}
