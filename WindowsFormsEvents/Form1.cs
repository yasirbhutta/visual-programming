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
           // button1.Click += new EventHandler(btn1_click2);
        }

        private void btn1_click(object sender, System.EventArgs e)
        {
            // Add event handler code here
            MessageBox.Show("Hello World");
        }

        /*
        private void btn1_click2(object sender, System.EventArgs e)
        {
            // Add event handler code here
            button1.BackColor = Color.SkyBlue;
           
        }
        */
    }
}
