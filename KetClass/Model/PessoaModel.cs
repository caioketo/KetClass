using KetClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class PessoaModel : BaseEntity
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
