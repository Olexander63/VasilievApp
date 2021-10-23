using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Threading.Tasks;


namespace VasilievApp
{
    class Program
    {
        static void Main(string[] args)
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

            string txt  = "Very pleasant " + name+"";
            // Windows message

            MessageBox.Show(txt, "The acquaintance took place");
            //MessageBox.Show("Learn C#","Windows name", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
