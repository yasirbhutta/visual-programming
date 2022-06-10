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

            myTxt.Text = "Enter your name";

            this.Controls.Add(myTxt);

            // button

            Button mybtn = new Button();

            mybtn.Location = new Point(50, 100);

            mybtn.Text = "Dynamic button";

            this.Controls.Add(mybtn);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            changeFormColor();
            if (textBox1.Text == "hide")
                btnShow.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
       {
            changeFormColor();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button7.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button5.Visible = true;
        }
    }
}
