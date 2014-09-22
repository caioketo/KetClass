using KetClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class LicaoModel : BaseEntity
    {
        public DateTime DataLicao { get; set; }
        public string Conteudo { get; set; }
        public int DisciplinaId { get; set; }
        public int TurmaId { get; set; }
        public bool Sinc { get; set; }

        public virtual DisciplinaModel Disciplina { get; set; }
        public virtual TurmaModel Turma { get; set; }

        public string DataFormatada
        {
            get
            {
                return DataLicao.ToString("dd/MM/yyyy");
            }
        }

        public string DisciplinaDesc
        {
            get
            {
                return Disciplina.Descricao;
            }
        }

        public string TurmaDesc
        {
            get
            {
                return Turma.Display;   
            }
        }
    }
}
