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
    public partial class FormAddTextBox : Form
    {
        public FormAddTextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox myText = new TextBox();
            myText.Location = new Point(25, 25);
            this.Controls.Add(myText);
        }
    }
}
