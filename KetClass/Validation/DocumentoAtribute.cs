using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace KetClass.Validation
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed public class DocumentoAtribute : ValidationAttribute
    {
        public DocumentoAtribute()
        {
        }
        
        public override bool IsValid(object value)
        {
            var documento = (String)value;
            bool result = true;
            if (documento.Length != 14)
            {
                result = false;
            }
            return result;
        }

        public override string FormatErrorMessage(string name)
        {
            return String.Format(CultureInfo.CurrentCulture,
              ErrorMessageString, name);
        }
    }
}
