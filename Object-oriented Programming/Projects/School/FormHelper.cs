using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class FormHelper
    {
        private readonly Form form;

        public FormHelper(Form _form)
        {
            form = _form;
        }

        public void ClearAllTextBoxes()
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;
            }
        }

        public bool AreAllTextBoxesFilled()
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (!textBox.ReadOnly && string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
