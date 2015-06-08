using KetClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class BoletimWebModel : BaseEntity
    {
        public BoletimWebModel()
        {

        }
        public BoletimWebModel(Newtonsoft.Json.Linq.JObject jsonObject)
        {
            WebId = (int)jsonObject.GetValue("Id");
            AlunoId = (int)jsonObject.GetValue("AlunoCId");
            DisciplinaId = (int)jsonObject.GetValue("DisciplinaId");
            PrecisaSinc = false;
        }
        public int WebId { get; set; }
        public int AlunoId { get; set; }
        public int DisciplinaId { get; set; }
        public bool PrecisaSinc { get; set; }
    }
}
