using KetClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class AlunoJSON : BaseEntity
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }  
        //UnidadePeriodoCursoAnoTurmaNumero
        public string UPCATN { get; set; }
        public int CId { get; set; }
        public int Ano { get; set; }
        public string Turma { get; set; }
        public int Numero { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public AlunoJSON()
        {

        }

        public AlunoJSON(AlunoModel aluno)
        {
            this.CId = aluno.Id;
            this.Nome = aluno.Aluno.Nome;
            this.Codigo = aluno.Codigo;
            this.Ano = aluno.Turma.Serie;
            this.Turma = aluno.Turma.Descricao;
            this.Numero = aluno.Numero;
            this.UPCATN = "Unid.: " + aluno.Turma.Curso.UnidadeDescricao + " Período: " +
                aluno.Turma.Curso.PeriodoDescricao + " Curso: " + aluno.Turma.CursoDescricao + " Ano: " + aluno.Turma.Serie +
                " Turma: " + aluno.Turma.Descricao;
            this.Email = aluno.Email;
            this.Senha = aluno.Senha;
        }
    }
}
