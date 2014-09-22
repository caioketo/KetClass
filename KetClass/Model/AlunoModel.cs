using KetClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class AlunoModel : BaseEntity
    {
        public string Codigo { get; set; }
        public string Sexo { get; set; }
        public string Cor { get; set; }
        public string CN { get; set; }
        public PessoaModel Aluno { get; set; }
        public PessoaModel Pai { get; set; }
        public PessoaModel Mae { get; set; }
        public PessoaModel Responsavel { get; set; }
        public EnderecoModel Endereo { get; set; }
        public TurmaModel Turma { get; set; }
        public int Numero { get; set; }
        public DateTime DataMatricula { get; set; }
        public CursoModel Curso
        {
            get
            {
                if (Turma != null)
                {
                    return Turma.Curso;
                }
                else
                {
                    return null;
                }
            }
        }

        public int Ano
        {
            get
            {
                if (Turma != null)
                {
                    if (Turma.Curso != null)
                    {
                        return Turma.Curso.Ano;
                    }
                }
                return 0;
            }
        }

        public PeriodoModel Periodo
        {
            get
            {
                if (Turma != null)
                {
                    if (Turma.Curso != null)
                    {
                        return Turma.Curso.Periodo;
                    }
                }
                return null;
            }
        }

        public UnidadeModel Unidade
        {
            get
            {
                if (Turma != null)
                {
                    if (Turma.Curso != null)
                    {
                        return Turma.Curso.Unidade;
                    }
                }
                return null;
            }
        }

        public string AlunoNome
        {
            get
            {
                if (Aluno == null)
                {
                    return "";
                }
                return Aluno.Nome;
            }
        }
        public string PaiNome
        {
            get
            {
                if (Pai == null)
                {
                    return "";
                }
                return Pai.Nome;
            }
        }
        public string MaeNome
        {
            get
            {
                if (Mae == null)
                {
                    return "";
                }
                return Mae.Nome;
            }
        }


        public AlunoModel()
        {
            this.Aluno = new PessoaModel();
            this.Pai = new PessoaModel();
            this.Mae = new PessoaModel();
        }
    }
}
