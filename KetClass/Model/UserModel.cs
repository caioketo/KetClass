using KetClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class UserModel : BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }

        public virtual ICollection<RoleModel> Roles { get; set; }
    }
}
