using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCommon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }



        private void changeFormColor()
        {
            if (textBox1.Focused)
                this.BackColor = Color.Aqua;
            else if (textBox2.Focused)
                this.BackColor = Color.Beige;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            TextBox myTxt = new TextBox();
            myTxt.Location = new Point(50, 50);
            this.Controls.Add(myTxt);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            changeFormColor();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            changeFormColor();
        }
    }
}
