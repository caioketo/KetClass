using KetClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class LoginModel : BaseEntity
    {
        string Login { get; set; }
        string Password { get; set; }
        string Nome { get; set; }
        string Permissoes { get; set; }
    }
}
