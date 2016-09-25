using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Util
{
    public class ComboBoxItem
    {
        string text;
        int value;

        public string Text
        {
            get
            {
                return text;
            }
        }

        public int Value
        {
            get
            {
                return value;
            }
        }

        public ComboBoxItem(string text, int value)
        {
            this.text = text;
            this.value = value;
        }
    }
}
