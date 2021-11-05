using Microsoft.VisualBasic;
using System.Windows.Forms;


namespace VasilievApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //text variables
            string name;

            //Отображение окна с полем ввода:
            //Displaying a window with an input field:

            name = Interaction.InputBox(
                "Whats your name?", //text on input
                "Let's get acquainted " // name input
            );
            //Another text variable

            var txt = "Very pleasant " + name + "";
            // Windows message

            MessageBox.Show(txt, "The acquaintance took place");
            //MessageBox.Show("Learn C#","Windows name", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}