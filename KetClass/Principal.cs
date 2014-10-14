using KetClass.Data;
using KetClass.Model;
using KetClass.View.Alunos;
using KetClass.View.Cursos;
using KetClass.View.Disciplinas;
using KetClass.View.Licao;
using KetClass.View.Notas;
using KetClass.View.Periodo;
using KetClass.View.Provas;
using KetClass.View.Shared;
using KetClass.View.Turmas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        public void EnviaLicao(LicaoJSON licao)
        {
            String result = "";
            string strPost = JsonConvert.SerializeObject(licao).ToString();
            strPost = "licaoJSON=" + Convert.ToBase64String(Encoding.UTF8.GetBytes(strPost));
            StreamWriter myWriter = null;
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create("http://www.escolareginaaltman.com.br/Licao/CreateJSON");
            objRequest.Method = "POST";
            objRequest.ContentLength = strPost.Length;
            objRequest.ContentType = "application/x-www-form-urlencoded";
            try
            {
                myWriter = new StreamWriter(objRequest.GetRequestStream());
                myWriter.Write(strPost);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                myWriter.Close();
            }

            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            {
                result = sr.ReadToEnd();
                sr.Close();
            }
        }

        public void EnviaProva(ProvaModel prova)
        {
            String result = "";
            string strPost = JsonConvert.SerializeObject(prova).ToString();
            strPost = "provaJSON=" + Convert.ToBase64String(Encoding.UTF8.GetBytes(strPost));
            StreamWriter myWriter = null;
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create("http://www.escolareginaaltman.com.br/Prova/CreateJSON");
            objRequest.Method = "POST";
            objRequest.ContentLength = strPost.Length;
            objRequest.ContentType = "application/x-www-form-urlencoded";
            try
            {
                myWriter = new StreamWriter(objRequest.GetRequestStream());
                myWriter.Write(strPost);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                myWriter.Close();
            }

            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            {
                result = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KCContext context = KCContext.getInstance();
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[PeriodoModels] ([Descricao],[HoraInicio],[HoraFim],[DataExclusao],[DataCriacao],[DataAlteracao]) values " +
                            "('Matutino', '7:30', '12:00', NULL, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[UnidadeModels] ([Numero],[Descricao],[DataExclusao],[DataCriacao],[DataAlteracao]) values (1, 'Principal', null, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP) ");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[CursoModels] ([Descricao],[Ano],[PeriodoId],[UnidadeId] " +
                            ",[PrimeiraSerie],[UltimaSerie],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('Ensino Infantil', 2014, 1, 1, 1, 3, null, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[CursoModels] ([Descricao],[Ano],[PeriodoId],[UnidadeId] " +
                ",[PrimeiraSerie],[UltimaSerie],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('Ensino Fundamental', 2014, 1, 1, 1, 9, null, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[TurmaModels] ([Descricao],[CursoId],[Serie],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('Maternal I', 1, 0, null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[TurmaModels] ([Descricao],[CursoId],[Serie],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('Maternal II', 1, 0, null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[TurmaModels] ([Descricao],[CursoId],[Serie],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('Jardim', 1, 0, null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[TurmaModels] ([Descricao],[CursoId],[Serie],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('Pré', 1, 0, null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[TurmaModels] ([Descricao],[CursoId],[Serie],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('', 2, 1, null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[TurmaModels] ([Descricao],[CursoId],[Serie],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('', 2, 2, null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[TurmaModels] ([Descricao],[CursoId],[Serie],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('', 2, 3, null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[TurmaModels] ([Descricao],[CursoId],[Serie],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('', 2, 4, null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[TurmaModels] ([Descricao],[CursoId],[Serie],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('', 2, 5, null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[TurmaModels] ([Descricao],[CursoId],[Serie],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('A', 2, 6, null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[TurmaModels] ([Descricao],[CursoId],[Serie],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('B', 2, 6, null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[TurmaModels] ([Descricao],[CursoId],[Serie],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('A', 2, 7, null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[TurmaModels] ([Descricao],[CursoId],[Serie],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('B', 2, 7, null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[TurmaModels] ([Descricao],[CursoId],[Serie],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('A', 2, 8, null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[TurmaModels] ([Descricao],[CursoId],[Serie],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('A', 2, 9, null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[DisciplinaModels] ([Descricao],[Abreviatura],[NomeHistorico],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('Português', 'PORT', 'Português', null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[DisciplinaModels] ([Descricao],[Abreviatura],[NomeHistorico],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('Matemática', 'MAT', 'Matemática', null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[DisciplinaModels] ([Descricao],[Abreviatura],[NomeHistorico],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('História', 'HIST', 'História', null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[DisciplinaModels] ([Descricao],[Abreviatura],[NomeHistorico],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('Geografia', 'GEO', 'Geografia', null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[DisciplinaModels] ([Descricao],[Abreviatura],[NomeHistorico],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('Ciências', 'CIE', 'Ciências', null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[DisciplinaModels] ([Descricao],[Abreviatura],[NomeHistorico],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('Educação Física', 'FISI', 'Educação Física', null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[DisciplinaModels] ([Descricao],[Abreviatura],[NomeHistorico],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('Artes', 'ART', 'Artes', null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[DisciplinaModels] ([Descricao],[Abreviatura],[NomeHistorico],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('Espanhol', 'ESP', 'Espanhol', null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[DisciplinaModels] ([Descricao],[Abreviatura],[NomeHistorico],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('Inglês', 'ING', 'Inglês', null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[DisciplinaModels] ([Descricao],[Abreviatura],[NomeHistorico],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('Desenho Geométrico', 'DES', 'Desenho Geométrico', null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[DisciplinaModels] ([Descricao],[Abreviatura],[NomeHistorico],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('Informática', 'INF', 'Informática', null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[DisciplinaModels] ([Descricao],[Abreviatura],[NomeHistorico],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('Formação de Valores', 'FORM', 'Formação de Valores', null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
            context.Database.ExecuteSqlCommand("insert into [escolare_geral].[dbo].[DisciplinaModels] ([Descricao],[Abreviatura],[NomeHistorico],[DataExclusao],[DataCriacao],[DataAlteracao]) values ('Educação Musical', 'MUS', 'Educação Musical', null, CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)");
        }

        private void liçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastrarLiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (LicaoView c = new LicaoView())
            {
                c.ShowDialog();
            }
        }

        private void enviarLiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KCContext ctx = KCContext.getInstance();
            foreach (LicaoModel licao in ctx.Licoes.Where(l => !l.Sinc).ToList())
            {
                EnviaLicao(new LicaoJSON(licao));
                licao.Sinc = true;
                ctx.Entry(licao).State = EntityState.Modified;
                ctx.SaveChanges();
            }

            MessageBox.Show("Lições enviadas com sucesso!", "ERA ERP", MessageBoxButtons.OK);
        }

        private void enviarProvasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KCContext ctx = KCContext.getInstance();
            foreach (ProvaModel prova in ctx.Provas.Where(l => !l.Sinc).ToList())
            {
                EnviaProva(prova);
                prova.Sinc = true;
                ctx.Entry(prova).State = EntityState.Modified;
                ctx.SaveChanges();
            }

            MessageBox.Show("Provas enviadas com sucesso!", "ERA ERP", MessageBoxButtons.OK);
        }

        private void enviarProvasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ProvaView c = new ProvaView())
            {
                c.ShowDialog();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void feedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (CursoView c = new CursoView())
            {
                c.ShowDialog();
            }
        }

        private void períodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PeriodoView p = new PeriodoView())
            {
                p.ShowDialog();
            }
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DisciplinaView d = new DisciplinaView())
            {
                d.ShowDialog();
            }
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (TurmaView t = new TurmaView())
            {
                t.ShowDialog();
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CadastroNotas cadastro = new CadastroNotas())
            {
                SelecionaTurmaDisciplina sel = new SelecionaTurmaDisciplina();
                sel.ShowDialog();

                if (sel.TurmaSel == null || sel.DisciplinaSel == null)
                {
                    return;
                }

                cadastro.turma = sel.TurmaSel;
                cadastro.disciplina = sel.DisciplinaSel;
                cadastro.ShowDialog();
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NotasView view = new NotasView())
            {
                view.ShowDialog();
            }
        }
    }
}
