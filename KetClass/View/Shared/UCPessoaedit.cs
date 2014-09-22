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
            model.CPF = tbxCPF.Text;
            model.DataNascimento = dtpNascimento.Value;
            model.Nome = tbxNome.Text;
            model.RG = tbxRG.Text;
            model.Telefone = tbxTelefone.Text;
            model.LocalNascimento = tbxLocalNasc.Text;
            model.Nacionalidade = cmbNacionalidade.Text.Substring(0, 1);
        }

        public void MapearTela()
        {
            tbxCPF.Text = model.CPF;
            dtpNascimento.Value = model.DataNascimento;
            tbxNome.Text = model.Nome;
            tbxRG.Text = model.RG;
            tbxTelefone.Text = model.Telefone;
            tbxLocalNasc.Text = model.LocalNascimento;
            try
            {
                cmbNacionalidade.SelectedIndex = Convert.ToInt32(model.Nacionalidade.Substring(0, 1));
            }
            catch (Exception ex)
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
