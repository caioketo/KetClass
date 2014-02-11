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
    public partial class AlunoEdit : Form
    {
        public BaseEdit<AlunoModel> baseEdit = new BaseEdit<AlunoModel>();

        public AlunoEdit()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (baseEdit.Salvar())
            {
                this.Close();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
