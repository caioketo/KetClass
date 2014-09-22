using KetClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class LicaoJSON : BaseEntity
    {
        public DateTime DataLicao { get; set; }
        public string Conteudo { get; set; }
        public int DisciplinaId { get; set; }
        public int TurmaId { get; set; }
        public bool Sinc { get; set; }

        public LicaoJSON(LicaoModel licao)
        {
            this.DataLicao = licao.DataLicao;
            this.Conteudo = licao.Conteudo;
            this.DisciplinaId = licao.DisciplinaId;
            this.TurmaId = licao.TurmaId;
            this.Sinc = licao.Sinc;
            this.DataAlteracao = licao.DataAlteracao;
            this.DataCriacao = licao.DataCriacao;
        }
    }
}
