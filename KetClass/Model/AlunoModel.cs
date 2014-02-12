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
        public PessoaModel Aluno { get; set; }
        public PessoaModel Pai { get; set; }
        public PessoaModel Mae { get; set; }

        public AlunoModel()
        {
            this.Aluno = new PessoaModel();
            this.Pai = new PessoaModel();
            this.Mae = new PessoaModel();
        }
    }
}
