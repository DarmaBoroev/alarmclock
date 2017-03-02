using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Будильник_Бороев
{
    class NumericUpDown_My : System.Windows.Forms.NumericUpDown
    {
        public override string Text
        {
            get { return base.Text; }
            set
            {
                int numValue;
                if (int.TryParse(value, out numValue) & numValue >= 0 & numValue < 10)
                    base.Text = "0" + value;
                else base.Text = value;
            }
        }
    }
}
