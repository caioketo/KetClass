using KetClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class RoleModel : BaseEntity
    {
        public virtual ICollection<UserModel> Users { get; set; }
        public virtual ICollection<PermissaoModel> Permissoes { get; set; }
    }
}
