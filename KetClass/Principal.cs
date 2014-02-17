using KetClass.View.Alunos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetClass
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AlunoView view = new AlunoView())
            {
                view.ShowDialog();
            }
        }
    }
}
