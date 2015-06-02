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

namespace KetClass.View.Periodo
{
    public partial class PeriodoEdit : Form, IEdit
    {
        public BaseEdit<PeriodoModel> baseEdit = new BaseEdit<PeriodoModel>();

        private PeriodoModel model
        {
            get
            {
                return baseEdit.model;
            }
        }

        public PeriodoEdit()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Fechar();
        }

        public void Salvar()
        {
            Mapear();
            if (baseEdit.Salvar())
            {
                Fechar();
            }
        }

        public void Mapear()
        {
            model.Descricao = tbxDescricao.Text;
            model.HoraInicio = tbxInicio.Text;
            model.HoraFim = tbxFim.Text;
        }

        public void MapearTela()
        {
            if (baseEdit.estado == Data.Estado.Criando)
            {
                tbxFim.Clear();
                tbxDescricao.Clear();
                tbxInicio.Clear();
            }
            else
            {
                tbxInicio.Text = model.HoraInicio;
                tbxFim.Text = model.HoraFim;
                tbxDescricao.Text = model.Descricao;
            }
        }

        public void Fechar()
        {
            this.Close();
        }

        private void PeriodoEdit_Load(object sender, EventArgs e)
        {

        }

        private void PeriodoEdit_Shown(object sender, EventArgs e)
        {
            MapearTela();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void PeriodoEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SelectNextControl(Utils.Util.FindFocusedControl(this), true, true, true, true);
            }
        }
    }
}
