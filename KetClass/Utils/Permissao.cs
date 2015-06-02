using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Utils
{
    public class Permissao
    {
        public string Nome { get; set; }
        public string PermissaoNome { get; set; }

        public override string ToString()
        {
            return Nome;
        }

        public Permissao() { }
        public Permissao(string nome, string permissao)
        {
            this.Nome = nome;
            this.PermissaoNome = permissao;
        }
    }
}
