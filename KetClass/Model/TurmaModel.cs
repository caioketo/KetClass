using KetClass.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class TurmaModel : BaseEntity
    {
        public string Descricao { get; set; }
        public int CursoId { get; set; }
        [ForeignKey("CursoId")]
        public virtual CursoModel Curso { get; set; }

        public int Serie { get; set; }


        public virtual string CursoDescricao
        {
            get
            {
                if (Curso != null)
                {
                    return Curso.Descricao;
                }
                else
                {
                    return "";
                }
            }
        }

        public string Display
        {
            get
            {
                return ToString();
            }
        }

        public override string ToString()
        {
            if (Serie > 0)
            {
                return Serie.ToString() + "º Ano " + Descricao;
            }
            else
            {
                return Descricao;
            }            
        }
    }
}
