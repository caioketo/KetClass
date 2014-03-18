using KetClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class EnderecoModel : BaseEntity
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public CidadeModel Cidade { get; set; }
        public UFModel UF
        {
            get
            {
                if (Cidade != null)
                {
                    return Cidade.UF;
                }
                else
                {
                    return null;
                }
            }
        }

        public string CEP { get; set; }
        public string Telefone { get; set; }


    }
}
