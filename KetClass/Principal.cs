using KetClass.Controller;
using KetClass.Data;
using KetClass.Model;
using KetClass.View.Alunos;
using KetClass.View.Cursos;
using KetClass.View.Disciplinas;
using KetClass.View.Licao;
using KetClass.View.Login;
using KetClass.View.Matriculas;
using KetClass.View.Notas;
using KetClass.View.Periodo;
using KetClass.View.Provas;
using KetClass.View.Shared;
using KetClass.View.Turmas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Data.OleDb;
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
            using (Login login = new Login())
            {
                login.ShowDialog();
                if (!AutenticacaoController.getInstance().IsUsuarioLogado())
                {
                    if (System.Windows.Forms.Application.MessageLoop)
                    {
                        // Use this since we are a WinForms app
                        System.Windows.Forms.Application.Exit();
                    }
                    else
                    {
                        // Use this since we are a console app
                        System.Environment.Exit(1);
                    }
                    return;
                }
            }
            InitializeComponent();

            foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
            {
                if (AutenticacaoController.getInstance().Autoriza(menuItem.Name))
                {
                    menuItem.Visible = true;
                }
                else
                {
                    menuItem.Visible = false;
                }
            }

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
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create("http://localhost:49893/Licao/CreateJSON");//http://www.escolareginaaltman.com.br/Licao/CreateJSON");
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
            SelecionaTurmaDisciplina sel = new SelecionaTurmaDisciplina();
            sel.ShowDialog();

            if (sel.TurmaSel == null || sel.DisciplinaSel == null)
            {
                return;
            }
            while (sel.TurmaSel != null && sel.DisciplinaSel != null)
            {
                using (CadastroNotas cadastro = new CadastroNotas())
                {
                    cadastro.turma = sel.TurmaSel;
                    cadastro.disciplina = sel.DisciplinaSel;
                    cadastro.ShowDialog();
                    sel.ShowDialog();
                }
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NotasView view = new NotasView())
            {
                view.ShowDialog();
            }
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CreateRole log = new CreateRole())
            {                
                log.ShowDialog();
            }
        }

        private void importarDBFsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportaDBFParte1();
            ImportaDBFParte2();
            ImportaDBFParte3();
        }

        public void ImportaDBFParte3()
        {
            OleDbConnection oConn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\class;Extended Properties=dBase III");
            OleDbCommand command = new OleDbCommand("select * from MATRIC.dbf where SITALU_MAT = 1", oConn);
            oConn.Open();
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            oConn.Close();
            DataTableReader reader = dt.CreateDataReader();
            DataTable dtalunos = new DataTable();
            dtalunos.Load(reader);
            Controller<AlunoModel> alunoController = new Controller<AlunoModel>();
            alunoController.dbset = alunoController.context.Alunos;
            Controller<TurmaModel> turmaController = new Controller<TurmaModel>();
            turmaController.dbset = turmaController.context.Turmas;
            Controller<MatriculaModel> matriculaController = new Controller<MatriculaModel>();
            matriculaController.dbset = matriculaController.context.Matriculas;
            foreach (DataRow row in dtalunos.Rows)
            {
                string alunoNome = (string)row["NOMEXX_MAT"];
                string turmaDesc = (string)row["TURMAX_MAT"];
                int serie = Convert.ToInt32((string)row["SERIEX_MAT"]);
                AlunoModel aluno = alunoController.Index().Where(a => a.Aluno.Nome.Equals(alunoNome)).FirstOrDefault();
                TurmaModel turma = turmaController.Index().Where(t => t.Descricao.Equals(turmaDesc) && t.Serie == serie).FirstOrDefault();

                MatriculaModel matriculaOld = matriculaController.Index().Where(m => m.TurmaId == turma.Id && m.AlunoId == aluno.Id).FirstOrDefault();


                if (matriculaOld == null && aluno != null && turma != null)
                {
                    MatriculaModel matricula = new MatriculaModel();
                    matricula.Numero = 0;
                    matricula.Turma = turma;
                    matricula.Aluno = aluno;
                    if (!DBNull.Value.Equals(row["DTMATR_MAT"]))
                        matricula.DataMatricula = (DateTime)row["DTMATR_MAT"];
                    else
                        matricula.DataMatricula = DateTime.Now;

                    matriculaController.Create(matricula);
                }
            }
        }

        public void ImportaDBFParte2()
        {
            OleDbConnection oConn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\class;Extended Properties=dBase III");
            OleDbCommand command = new OleDbCommand("select * from CADFAM.dbf ", oConn);
            oConn.Open();
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            oConn.Close();
            DataTableReader reader = dt.CreateDataReader();
            DataTable dtalunos = new DataTable();
            dtalunos.Load(reader);
            Controller<AlunoModel> alunoController = new Controller<AlunoModel>();
            alunoController.dbset = alunoController.context.Alunos;
            Controller<PessoaModel> pessoaController = new Controller<PessoaModel>();
            pessoaController.dbset = pessoaController.context.Pessoas;
            foreach (DataRow row in dtalunos.Rows)
            {
                string codigoFam = (string)row["CODFAM_FAM"];
                List<AlunoModel> alunos = alunoController.Index().Where(a => a.CodigoFam.Equals(codigoFam)).ToList();
                PessoaModel pai = new PessoaModel();
                PessoaModel mae = new PessoaModel();
                bool insert = false;
                foreach (AlunoModel aluno in alunos)
                {                    
                    if ((aluno != null) && (aluno.Pai == null && aluno.Mae == null))
                    {
                        insert = true;
                    }
                }
                if (insert)
                {
                    pai.Nome = (string)row["NOMPAI_FAM"];
                    pai.Telefone = ((double)row["TELPAI_FAM"]).ToString();
                    mae.Nome = (string)row["NOMMAE_FAM"];
                    mae.Telefone = ((double)row["TELMAE_FAM"]).ToString();
                    pai = pessoaController.Create(pai);
                    mae = pessoaController.Create(mae);
                    
                }
                foreach (AlunoModel aluno in alunos)
                {                    
                    if ((aluno != null) && (aluno.Pai == null && aluno.Mae == null))
                    {
                        aluno.Pai = pai;
                        aluno.Mae = mae;

                        alunoController.Edit(aluno);
                    }
                }
            }
        }
        public void ImportaDBFParte1()
        {
            OleDbConnection oConn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\class;Extended Properties=dBase III");
            OleDbCommand command = new OleDbCommand("select * from ALUNOS.dbf", oConn);
            oConn.Open();
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            oConn.Close();
            DataTableReader reader = dt.CreateDataReader();
            DataTable dtalunos = new DataTable();
            dtalunos.Load(reader);
            Controller<AlunoModel> alunoController = new Controller<AlunoModel>();
            alunoController.dbset = alunoController.context.Alunos;
            foreach (DataRow row in dtalunos.Rows)
            {
                AlunoModel alunoOld = alunoController.Index().Where(a => a.Codigo.Equals(((double)row["CODIGO_ALU"]).ToString())).FirstOrDefault();
                if (alunoOld == null)
                {
                    AlunoModel aluno = new AlunoModel();
                    aluno.Codigo = ((double)row["CODIGO_ALU"]).ToString();
                    aluno.Aluno = new PessoaModel();
                    aluno.Aluno.Telefone = "1";
                    aluno.Aluno.Nome = (string)row["NOMEXX_ALU"];
                    aluno.Sexo = (string)row["SEXOXX_ALU"];
                    aluno.Aluno.DataNascimento = (DateTime)row["DATNAS_ALU"];
                    aluno.DataMatricula = (DateTime)row["DATCRI_ALU"];
                    aluno.Aluno.LocalNascimento = (string)row["LOCNAS_ALU"];
                    aluno.Aluno.Nacionalidade = (string)row["NACION_ALU"];
                    aluno.CodigoFam = (string)row["CODFAM_ALU"];
                    //aluno.Aluno.RG = (string)row["RGXXXX_ALU"];
                    if (!DBNull.Value.Equals(row["CERTNA_ALU"]))
                        aluno.Certidao = (string)row["CERTNA_ALU"];
                    else
                        aluno.Certidao = "";
                    aluno.Numero = 1;
                    aluno.Pai = null;
                    aluno.Mae = null;
                    alunoController.Create(aluno);
                }
            }
        }

        private void matrículasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MatriculaView t = new MatriculaView())
            {
                t.ShowDialog();
            }
        }

        private void testeBoletimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void testeBoletimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<int> alunosIds = new List<int>();

            foreach (NotaModel nota in KCContext.getInstance().Notas.ToList())
            {
                alunosIds.Add(nota.AlunoId);
            }

            Utils.Util.EnviarNotas(1, KCContext.getInstance().Alunos.Where(a => alunosIds.Contains(a.Id)).ToList());
        }

        private void testeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Util.EnviarAlunos();
        }
    }
}
