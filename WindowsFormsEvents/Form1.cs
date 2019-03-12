using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(btn1_click);
           // button1.Click += new EventHandler(btn_click);
           // button2.Click += new EventHandler(btn_click);
        }

        private void btn1_click(object sender, System.EventArgs e)
        {
            // Add event handler code here
            MessageBox.Show("Hello World");
        }


        private void btn_click(object sender, System.EventArgs e)
        {
            //Add event handler code here
            Button btn = (Button)sender;
            btn.BackColor = Color.Aqua;
            // show name
            label1.Text = btn.Name;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
