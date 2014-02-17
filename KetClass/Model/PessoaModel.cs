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
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo Telefone é obrigatório")]
        public string Telefone { get; set; }
        //[DocumentoAtribute(ErrorMessage = "O CPF {0} é inválido.")]
        //public string Documento { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
