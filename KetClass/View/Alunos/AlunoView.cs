using KetClass.Model;
using KetClass.View.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetClass.View.Alunos
{
    public partial class AlunoView : BaseView<AlunoModel>
    {
        public AlunoView()
        {
            this.grid = 
            InitializeComponent();
            Index();
        }
    }
}
