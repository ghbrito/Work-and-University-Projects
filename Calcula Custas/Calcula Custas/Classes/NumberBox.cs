using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Calcula_Custas.Classes
{
    public class NumberBox : TextBox
    {
        public NumberBox()
        {
            Fraction = 2;
        }

        public ErrorProvider ErrorProvider { get; set; }

        [DefaultValue(2)]
        public int Fraction { get; set; }

        public event EventHandler ValueChanged;
        public decimal Value
        {
            get { return this.value; }
            set
            {
                if (value != this.value)
                {
                    this.value = value;
                    this.Text = Value.ToString(string.Format("N{0}", Fraction));
                    var handler = ValueChanged;
                    if (handler != null) ValueChanged(this, EventArgs.Empty);
                }
            }
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            if (this.Text.Length > 0 && !e.Cancel)
            {
                decimal entry;
                if (decimal.TryParse(this.Text, out entry))
                {
                    if (ErrorProvider != null) ErrorProvider.SetError(this, "");
                    Value = entry;
                }
                else
                {
                    if (ErrorProvider != null) ErrorProvider.SetError(this, "Please enter a valid number");
                    this.SelectAll();
                    e.Cancel = true;
                }
            }
            base.OnValidating(e);
        }

        protected override void OnEnter(EventArgs e)
        {
            this.SelectAll();
            base.OnEnter(e);
        }


        private decimal value;
    }
}
