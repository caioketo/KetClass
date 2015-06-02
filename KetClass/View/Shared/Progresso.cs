using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetClass.View.Shared
{
    public partial class Progresso : Form
    {
        int maximo = 0;
        public Progresso()
        {
            InitializeComponent();
        }

        public void Iniciar(BackgroundWorker worker, int max = 0, string texto = "Carregando...")
        {
            if (max <= 0)
            {
                lblProgresso.Text = "";
            }
            else
            {
                lblProgresso.Text = "0/" + max.ToString();
                maximo = max;
            }
            progressBar.Maximum = max;
            worker.RunWorkerAsync();
            this.Text = texto;
            this.ShowDialog();
        }

        public void Incrementar(int valor = 1)
        {
            lblProgresso.Text = (progressBar.Value + valor).ToString()  + "/" + maximo.ToString();
            progressBar.Increment(valor);
        }

        public void SetPosition(int posicao)
        {
            lblProgresso.Text = posicao.ToString() + "/" + maximo.ToString();
            progressBar.Value = posicao;
        }

        private void Progresso_Shown(object sender, EventArgs e)
        {
        }
    }
}
