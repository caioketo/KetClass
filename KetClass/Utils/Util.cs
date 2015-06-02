using KetClass.Controller;
using KetClass.Data;
using KetClass.Model;
using KetClass.View.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetClass.Utils
{
    class Util
    {
        static BackgroundWorker worker;
        static Progresso progresso;
        static List<BoletimJSON> notasJSON;
        static int count;

        public static Control FindFocusedControl(Control control)
        {
            var container = control as IContainerControl;
            while (container != null)
            {
                control = container.ActiveControl;
                container = control as IContainerControl;
            }
            return control;
        }

        public static void EnviarNotas(int trimestre, List<AlunoModel> alunos)
        {
            Controller<NotaModel> notasController = new Controller<NotaModel>();
            notasController.dbset = notasController.context.Notas;
            notasJSON = new List<BoletimJSON>();
            foreach (AlunoModel aluno in alunos)
            {
                List<NotaModel> notas = notasController.Filter(n => n.AlunoId == aluno.Id && n.Trimestre == trimestre).OrderBy(n => n.DisciplinaId).ToList();
                NotaBoletimJSON notaJSON = null;
                BoletimJSON boletim = null;
                int disciplinaId = -1;
                foreach (NotaModel nota in notas)
                {
                    if (disciplinaId != nota.DisciplinaId)
                    {
                        if (notaJSON != null)
                        {
                            boletim.NotaTrim1 = notaJSON;
                            notasJSON.Add(boletim);

                            boletim = new BoletimJSON();
                            boletim.AlunoId = aluno.Id;
                            boletim.DisciplinaId = nota.DisciplinaId;
                        }
                        if (boletim == null)
                        {
                            boletim = new BoletimJSON();
                            boletim.AlunoId = aluno.Id;
                            boletim.DisciplinaId = nota.DisciplinaId;
                        }
                        disciplinaId = nota.DisciplinaId;
                        notaJSON = new NotaBoletimJSON();
                    }
                    notaJSON.AulasDadas = nota.AulasDadas;
                    notaJSON.Faltas = nota.Faltas;
                    if (nota.Recupercao)
                    {
                        notaJSON.Rec = nota.Nota;
                    }
                    else
                    {
                        notaJSON.Nota = nota.Nota;
                    }                    
                }
                boletim.NotaTrim1 = notaJSON;
                notasJSON.Add(boletim);
            }

            worker = new BackgroundWorker();
            progresso = new Progresso();
            worker.DoWork += backgroundWorker1_DoWork;
            worker.ProgressChanged += backgroundWorker1_ProgressChanged;
            worker.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            worker.WorkerReportsProgress = true;
            count = 0;
            progresso.Iniciar(worker, notasJSON.Count, "Enviando notas...");            
        }

        private static void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progresso.Close();
        }

        private static void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progresso.SetPosition(count);
        }

        private static void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (BoletimJSON boletim in notasJSON)
            {
                EnviaBoletim(boletim);
                count++;
                worker.ReportProgress(count);
            }
        }

        public static void EnviaBoletim(BoletimJSON boletim)
        {
            Controller<BoletimWebModel> webController = new Controller<BoletimWebModel>();
            webController.dbset = webController.context.BoletinsWeb;

            if (webController.Filter(b => b.AlunoId == boletim.AlunoId && b.DisciplinaId == boletim.DisciplinaId).ToList().Count > 0)
            {
                BoletimWebModel boletimWeb = webController.Filter(b => b.AlunoId == boletim.AlunoId && b.DisciplinaId == boletim.DisciplinaId).First();
                if (boletimWeb.PrecisaSinc)
                {
                    //Editar
                    String result = "";
                    string strPost = JsonConvert.SerializeObject(boletim).ToString();
                    strPost = "boletimId=" + boletimWeb.WebId.ToString() + "&boletimJSON=" + Convert.ToBase64String(Encoding.UTF8.GetBytes(strPost));
                    StreamWriter myWriter = null;
                    HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create("http://localhost:49893/Boletim/EditJSON");//http://www.escolareginaaltman.com.br/Licao/CreateJSON");
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
                        boletimWeb.PrecisaSinc = false;
                        webController.Edit(boletimWeb);
                        sr.Close();
                    }
                }
            }
            else
            {
                String result = "";
                string strPost = JsonConvert.SerializeObject(boletim).ToString();
                strPost = "boletimJSON=" + Convert.ToBase64String(Encoding.UTF8.GetBytes(strPost));
                StreamWriter myWriter = null;
                HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create("http://localhost:49893/Boletim/CreateJSON");//http://www.escolareginaaltman.com.br/Licao/CreateJSON");
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
                    JObject jsonObject = JsonConvert.DeserializeObject<JObject>(result);
                    BoletimWebModel boletimWeb = new BoletimWebModel(jsonObject);
                    if (webController.Filter(b => b.WebId == boletimWeb.WebId).Count() <= 0)
                    {
                        webController.Create(boletimWeb);
                    }
                    sr.Close();
                }
            }            
        }

        public static List<Permissao> LoadPermissoes()
        {
            List<Permissao> permissoes = new List<Permissao>();
            permissoes.Add(new Permissao("Alunos", "alunosToolStripMenuItem"));
            permissoes.Add(new Permissao("Cadastrar Provas", "enviarProvasToolStripMenuItem"));
            permissoes.Add(new Permissao("Enviar Provas", "enviarProvasToolStripMenuItem1"));
            permissoes.Add(new Permissao("Cadastrar Lições", "cadastrarLiçãoToolStripMenuItem"));
            permissoes.Add(new Permissao("Enviar Lições", "enviarLiçõesToolStripMenuItem"));
            permissoes.Add(new Permissao("Cadastro de Cursos", "cursosToolStripMenuItem1"));
            permissoes.Add(new Permissao("Cadastro de Períodos", "períodosToolStripMenuItem"));
            permissoes.Add(new Permissao("Cadastro de Disciplinas", "disciplinasToolStripMenuItem"));
            permissoes.Add(new Permissao("Cadastro de Turmas", "turmasToolStripMenuItem"));
            permissoes.Add(new Permissao("Cadastro de Notas", "cadastrarToolStripMenuItem"));
            permissoes.Add(new Permissao("Visualizar Notas", "viewToolStripMenuItem"));
            permissoes.Add(new Permissao("Matrículas", "matrículasToolStripMenuItem"));


            
            

            return permissoes;
        }
    }
}
