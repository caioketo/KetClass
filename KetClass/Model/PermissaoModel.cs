using KetClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class PermissaoModel : BaseEntity
    {
        public virtual ICollection<RoleModel> Roles { get; set; }
        public string Codigo { get; set; }
    }
}
