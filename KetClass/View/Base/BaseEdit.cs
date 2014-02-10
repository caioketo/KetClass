using KetClass.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetClass.View.Base
{
    public class BaseEdit<T> : Form where T : BaseEntity
    {
        public IController<T> controller { get; set; }
        public T model { get; set; }
        public Estado estado { get; set; }

        public void Show()
        {
        }

        public void Close()
        {
        }

        public void Salvar()
        {
            var erros = new List<ValidationResult>();
            if (!Validator.TryValidateObject(model, new ValidationContext(model, null, null), erros, true))
            {
                foreach (ValidationResult erro in erros)
                {
                    MessageBox.Show(erro.ErrorMessage);
                }
                return;
            }
            if (estado == Estado.Criando)
            {
                controller.Create(model);
            }
            else if (estado == Estado.Editando)
            {
                controller.Edit(model);
            }
            Close();
        }
        
    }
}
