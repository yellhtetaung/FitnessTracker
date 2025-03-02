using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FitnessTracker
{
    class TextBoxController
    {
        public static void Placeholder (TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;
        }

        public static void Placeholder(TextBox textBox, string placeholder, Color color)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = color;
        }
    }
}
