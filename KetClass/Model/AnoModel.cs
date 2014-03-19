using KetClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class AnoModel : BaseEntity
    {
        public int Ano { get; set; }

        public override string ToString()
        {
            return Ano.ToString();
        }
    }
}
