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
    public partial class MouseEnterLeave : Form
    {
        public MouseEnterLeave()
        {
            InitializeComponent();
        }

        private void MouseEnterLeave_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void MouseEnterLeave_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void MouseEnterLeave_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
