using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class BoletimJSON
    {
        public int AlunoCId { get; set; }
        public int DisciplinaId { get; set; }
        public NotaBoletimJSON NotaTrim1 { get; set; }
        public NotaBoletimJSON NotaTrim2 { get; set; }
        public NotaBoletimJSON NotaTrim3 { get; set; }
    }
}
