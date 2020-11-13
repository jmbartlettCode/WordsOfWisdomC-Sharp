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
using System.Windows.Forms;

namespace WordsOfWisdom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // when the mouse moves over the first quote label area change the label background to white
        private void labelQuote1_MouseMove(object sender, MouseEventArgs e)
        {
            labelQuote1.BackColor = System.Drawing.Color.White;
        }
        // when the mouse moves over the second quote label area change the label background to white
        private void labelQuote2_MouseMove(object sender, MouseEventArgs e)
        {
            labelQuote2.BackColor = System.Drawing.Color.White;
        }
        // when the mouse moves over the third quote label area change the label background to white
        private void labelQuote3_MouseMove(object sender, MouseEventArgs e)
        {
            labelQuote3.BackColor = System.Drawing.Color.White;
        }
        // when the mouse moves over the fourth quote label area change the label background to white
        private void labelQuote4_MouseMove(object sender, MouseEventArgs e)
        {
            labelQuote4.BackColor = System.Drawing.Color.White;
        }
        // when the mouse leaves the first quote label area change the label background to dark gray
        private void labelQuote1_MouseLeave(object sender, EventArgs e)
        {
            labelQuote1.BackColor = System.Drawing.Color.DarkGray;
        }
        // when the mouse leaves the second quote label area change the label background to dark gray
        private void labelQuote2_MouseLeave(object sender, EventArgs e)
        {
            labelQuote2.BackColor = System.Drawing.Color.DarkGray;
        }
        // when the mouse leaves the third quote label area change the label background to dark gray
        private void labelQuote3_MouseLeave(object sender, EventArgs e)
        {
            labelQuote3.BackColor = System.Drawing.Color.DarkGray;
        }
        // when the mouse leaves the fourth quote label area change the label background to dark gray
        private void labelQuote4_MouseLeave(object sender, EventArgs e)
        {
            labelQuote4.BackColor = System.Drawing.Color.DarkGray;
        }
    }
}
