using KetClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetClass.View
{
    public class BaseView<T> where T : BaseEntity
    {
        public DataGridView grid { get; set; }
        public IController<T> controller { get; set; }

        public void Index()
        {
            grid.DataSource = controller.Index();
        }
    }
}
