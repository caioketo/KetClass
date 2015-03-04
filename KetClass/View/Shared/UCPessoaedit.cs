using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KetClass.View.Base;
using KetClass.Model;
using KetClass.Controller;
using KetClass.Data;

namespace KetClass.View.Shared
{
    public partial class UCPessoaedit : UserControl, IEdit
    {
        public BaseEdit<PessoaModel> baseEdit = new BaseEdit<PessoaModel>();
        public PessoaController controller = new PessoaController();
        public Controller<PessoaModel> cont = new Controller<PessoaModel>();
        private bool isPai = false;
        public void SetPai()
        {
            isPai = true;
            lblTel.Left = lblRG.Left;
            lblTel.Top = lblRG.Top;
            tbxTelefone.Top = tbxRG.Top;
            tbxTelefone.Left = tbxRG.Left;
            gbxGeral.Width = this.Width - 10;
            gbxGeral.Height = this.Height - 5;

            lblRG.Visible = false;
            tbxRG.Visible = false;
            lblCPF.Visible = false;
            tbxCPF.Visible = false;
            lblLocal.Visible = false;
            tbxLocalNasc.Visible = false;
            lblNascimento.Visible = false;
            dtpNascimento.Visible = false;
            lblNascionalidade.Visible = false;
            cmbNacionalidade.Visible = false;
        }

        KCContext context = KCContext.getInstance();
        public string Nome 
        {
            get
            {
                return gbxGeral.Text;
            }
            set
            {
                gbxGeral.Text = value;
            }
        }

        public PessoaModel model
        {
            get
            {
                return baseEdit.model;
            }
        }
        
        public UCPessoaedit()
        {
            InitializeComponent();
            cont.dbset = context.Pessoas;
            baseEdit.model = null;
            baseEdit.controller = cont;
        }


        public void Salvar()
        {
            Mapear();
            //return baseEdit.Salvar();
        }

        public void Mapear()
        {
            model.Nome = tbxNome.Text;
            model.Telefone = tbxTelefone.Text;
            if (!isPai)
            {
                model.CPF = tbxCPF.Text;
                model.DataNascimento = dtpNascimento.Value;                
                model.RG = tbxRG.Text;                
                model.LocalNascimento = tbxLocalNasc.Text;
                model.Nacionalidade = cmbNacionalidade.Text.Substring(0, 1);
            }
            else
            {

            }
        }

        public void MapearTela()
        {
            tbxCPF.Text = model.CPF;
            if (model.DataNascimento.HasValue)
            {
                dtpNascimento.Value = model.DataNascimento.Value;
            }
            tbxNome.Text = model.Nome;
            tbxRG.Text = model.RG;
            tbxTelefone.Text = model.Telefone;
            tbxLocalNasc.Text = model.LocalNascimento;
            try
            {
                cmbNacionalidade.SelectedIndex = Convert.ToInt32(model.Nacionalidade.Substring(0, 1));
            }
            catch (Exception)
            {
                cmbNacionalidade.SelectedIndex = 0;
            }
        }

        public void Fechar()
        {
            //
        }

        public void Clear()
        {
            tbxCPF.Clear();
            dtpNascimento.Value = DateTime.Now;
            tbxNome.Clear();
            tbxRG.Clear();
            tbxTelefone.Clear();
            tbxLocalNasc.Clear();
        }

        private void tbxNome_Leave(object sender, EventArgs e)
        {
            if (cont.Filter(p => p.Nome.Contains(tbxNome.Text)).ToList().Count == 1)
            {
                baseEdit.model = cont.Filter(p => p.Nome.Contains(tbxNome.Text)).FirstOrDefault();
                MapearTela();
            }
        }
    }
}
