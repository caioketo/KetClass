using KetClass.Data;
using KetClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetClass.Controller
{
    public class BoletimController
    {
        private KCContext context = KCContext.getInstance();


        public void feed(int alunoId)
        {
            List<NotasBoletimModel> notasParaBoletim = new List<NotasBoletimModel>();
            AlunoModel aluno = context.Alunos.Find(alunoId);
            IQueryable<NotaModel> notas = context.Notas.Where(n => n.TurmaId == aluno.Turma.Id && n.Numero == aluno.Numero);
            IQueryable<NotaModel> notas1Trim = notas.Where(n => n.Trimestre == 1);
            IQueryable<NotaModel> notas2Trim = notas.Where(n => n.Trimestre == 2);
            IQueryable<NotaModel> notas3Trim = notas.Where(n => n.Trimestre == 3);
            foreach (DisciplinaModel disciplina in context.Disciplinas.Where(d => !d.DataExclusao.HasValue).ToList())
            {
                if (notas1Trim.Count() > 0)
                {
                    NotasBoletimModel notaBoletim1 = new NotasBoletimModel();
                    notaBoletim1.Disciplina = disciplina;
                    notaBoletim1.Aluno = aluno;
                    NotaModel notasRec = notas1Trim.Where(n => n.Recupercao).FirstOrDefault();
                    NotaModel notasNRec = notas1Trim.Where(n => n.Recupercao).FirstOrDefault();
                    if (notasRec != null)
                    {
                        notaBoletim1.Rec = notasRec.Nota;
                    }
                    else
                    {
                        notaBoletim1.Rec = 0;
                    }
                    notaBoletim1.Nota = notasNRec.Nota;
                    notaBoletim1.Faltas = notasNRec.Faltas;
                    notaBoletim1.Trimestre = 1;
                    notasParaBoletim.Add(notaBoletim1);
                }

                if (notas2Trim.Count() > 0)
                {
                    NotasBoletimModel notaBoletim2 = new NotasBoletimModel();
                    notaBoletim2.Disciplina = disciplina;
                    notaBoletim2.Aluno = aluno;
                    NotaModel notasRec = notas2Trim.Where(n => n.Recupercao).FirstOrDefault();
                    NotaModel notasNRec = notas2Trim.Where(n => n.Recupercao).FirstOrDefault();
                    if (notasRec != null)
                    {
                        notaBoletim2.Rec = notasRec.Nota;
                    }
                    else
                    {
                        notaBoletim2.Rec = 0;
                    }
                    notaBoletim2.Nota = notasNRec.Nota;
                    notaBoletim2.Faltas = notasNRec.Faltas;
                    notaBoletim2.Trimestre = 2;
                    notasParaBoletim.Add(notaBoletim2);
                }

                if (notas3Trim.Count() > 0)
                {
                    NotasBoletimModel notaBoletim3 = new NotasBoletimModel();
                    notaBoletim3.Disciplina = disciplina;
                    notaBoletim3.Aluno = aluno;
                    NotaModel notasRec = notas3Trim.Where(n => n.Recupercao).FirstOrDefault();
                    NotaModel notasNRec = notas3Trim.Where(n => n.Recupercao).FirstOrDefault();
                    if (notasRec != null)
                    {
                        notaBoletim3.Rec = notasRec.Nota;
                    }
                    else
                    {
                        notaBoletim3.Rec = 0;
                    }
                    notaBoletim3.Nota = notasNRec.Nota;
                    notaBoletim3.Faltas = notasNRec.Faltas;
                    notaBoletim3.Trimestre = 3;
                    notasParaBoletim.Add(notaBoletim3);
                }
            }
        }
    }
}
