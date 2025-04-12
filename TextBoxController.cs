using System.Drawing;
using System.Windows.Forms;

namespace FitnessTracker
{
    class TextBoxController
    {
        public static void Placeholder(TextBox textBox, string placeholder)
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
