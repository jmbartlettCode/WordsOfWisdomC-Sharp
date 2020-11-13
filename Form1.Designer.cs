/* 
Josh Bartlett
9Aug2019
Assignment 8.2
Form containing at least four Labels that hold "wise" quotes. When the program starts, the background 
color of the Form and each Label are be black.  When the user passes a mouse over a Label, change 
its BackColor to white, revealing the text of the quote. When the mouse leaves the label area change
label BackColor to dark gray.
*/

namespace WordsOfWisdom
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelQuote1 = new System.Windows.Forms.Label();
            this.labelQuote2 = new System.Windows.Forms.Label();
            this.labelQuote3 = new System.Windows.Forms.Label();
            this.labelQuote4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuote1
            // 
            this.labelQuote1.AutoSize = true;
            this.labelQuote1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuote1.Location = new System.Drawing.Point(64, 77);
            this.labelQuote1.Name = "labelQuote1";
            this.labelQuote1.Size = new System.Drawing.Size(375, 20);
            this.labelQuote1.TabIndex = 0;
            this.labelQuote1.Text = "\"Lost time is never found again.\" - Benjamin Franklin";
            this.labelQuote1.MouseLeave += new System.EventHandler(this.labelQuote1_MouseLeave);
            this.labelQuote1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelQuote1_MouseMove);
            // 
            // labelQuote2
            // 
            this.labelQuote2.AutoSize = true;
            this.labelQuote2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuote2.Location = new System.Drawing.Point(64, 134);
            this.labelQuote2.Name = "labelQuote2";
            this.labelQuote2.Size = new System.Drawing.Size(674, 20);
            this.labelQuote2.TabIndex = 1;
            this.labelQuote2.Text = "\"In the end, it\'s not the years in your life that count. It\'s the life in your ye" +
    "ars.\" - Abraham Lincoln";
            this.labelQuote2.MouseLeave += new System.EventHandler(this.labelQuote2_MouseLeave);
            this.labelQuote2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelQuote2_MouseMove);
            // 
            // labelQuote3
            // 
            this.labelQuote3.AutoSize = true;
            this.labelQuote3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuote3.Location = new System.Drawing.Point(65, 224);
            this.labelQuote3.Name = "labelQuote3";
            this.labelQuote3.Size = new System.Drawing.Size(446, 20);
            this.labelQuote3.TabIndex = 2;
            this.labelQuote3.Text = "\"Only a life lived for others is a life worthwhile.\" - Albert Einstein";
            this.labelQuote3.MouseLeave += new System.EventHandler(this.labelQuote3_MouseLeave);
            this.labelQuote3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelQuote3_MouseMove);
            // 
            // labelQuote4
            // 
            this.labelQuote4.AutoSize = true;
            this.labelQuote4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuote4.Location = new System.Drawing.Point(65, 324);
            this.labelQuote4.Name = "labelQuote4";
            this.labelQuote4.Size = new System.Drawing.Size(664, 20);
            this.labelQuote4.TabIndex = 3;
            this.labelQuote4.Text = "\"I\'ve failed over and over and over again in my life and that is why I succeed.\" " +
    "- Michael Jordan";
            this.labelQuote4.MouseLeave += new System.EventHandler(this.labelQuote4_MouseLeave);
            this.labelQuote4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelQuote4_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelQuote4);
            this.Controls.Add(this.labelQuote3);
            this.Controls.Add(this.labelQuote2);
            this.Controls.Add(this.labelQuote1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Words of Wisdom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuote1;
        private System.Windows.Forms.Label labelQuote2;
        private System.Windows.Forms.Label labelQuote3;
        private System.Windows.Forms.Label labelQuote4;
    }
}

