using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Data
{
    public interface ICRUD
    {
        BaseEntity Pesquisar(string texto = "");
    }
}
