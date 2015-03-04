using KetClass.Model;
using KetClass.View.Base;
using KetClass.View.Periodo;
using KetClass.View.Unidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetClass.View.Cursos
{
    public partial class CriarCurso : Form, IEdit
    {
        
        public BaseEdit<CursoModel> baseEdit = new BaseEdit<CursoModel>();
 
        private CursoModel model
        {
            get
            {
                return baseEdit.model;
            }
        }

        public CriarCurso()
        {
            InitializeComponent();
            pesPeriodo.Crud = new PeriodoView();
            pesUnidade.Crud = new UnidadeView();
        }

        private void CriarCurso_Shown(object sender, EventArgs e)
        {
            MapearTela();
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
            model.Unidade = (UnidadeModel)pesUnidade.Objeto;
            model.Periodo = (PeriodoModel)pesPeriodo.Objeto;
            model.Descricao = tbxDescricao.Text;
            model.PrimeiraSerie = Convert.ToInt32(tbxPSerie.Text);
            model.UltimaSerie = Convert.ToInt32(tbxUSerie.Text);
        }

        public void MapearTela()
        {
            if (baseEdit.estado == Data.Estado.Criando)
            {
                tbxDescricao.Clear();
                pesUnidade.Clear();
                pesPeriodo.Clear();
                tbxUSerie.Clear();
                tbxPSerie.Clear();
            }
            else
            {
                tbxPSerie.Text = model.PrimeiraSerie.ToString();
                tbxUSerie.Text = model.UltimaSerie.ToString();
                tbxDescricao.Text = model.Descricao;
                pesPeriodo.SetObjeto(model.Periodo);
                pesUnidade.SetObjeto(model.Unidade);
            }
        }

        public void Fechar()
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();    
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Fechar();
        }

        private void CriarCurso_Load(object sender, EventArgs e)
        {

        }
    }
}
