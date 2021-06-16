using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls_Part1
{
    public partial class GroupBoxPanelExampleForm : Form
    {
        public GroupBoxPanelExampleForm()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "hi pressed";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "bye pressed";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Far Left pressed";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Far Right pressed";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
