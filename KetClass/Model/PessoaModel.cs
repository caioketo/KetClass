using KetClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using KetClass.Validation;

namespace KetClass.Model
{
    public class PessoaModel : BaseEntity
    {
        //[Required(AllowEmptyStrings = false, ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        //[Required(AllowEmptyStrings = false, ErrorMessage = "O campo Telefone é obrigatório")]
        public string Telefone { get; set; }

        public Nullable<DateTime> DataNascimento { get; set; }

        public string LocalNascimento { get; set; }

        public string RG { get; set; }        

        //[DocumentoAtribute(ErrorMessage = "O CPF {0} é inválido.")]
        public string CPF { get; set; }

        public string Nacionalidade { get; set; }

        public string Convenio { get; set; }


        public override string ToString()
        {
            return Nome;
        }
    }
}
