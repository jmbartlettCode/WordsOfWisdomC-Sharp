/* 
Josh Bartlett
9Aug2019
Assignment 8.2
Form containing at least four Labels that hold "wise" quotes. When the program starts, the background 
color of the Form and each Label are be black.  When the user passes a mouse over a Label, change 
its BackColor to white, revealing the text of the quote. When the mouse leaves the label area change
label BackColor to dark gray.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsOfWisdom
{
    static class WordsOfWisdom
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
