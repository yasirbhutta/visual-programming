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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBoxTestForm frm = new CheckBoxTestForm();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GroupBoxPanelExampleForm frm = new GroupBoxPanelExampleForm();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RadioButtonsTestForm frm = new RadioButtonsTestForm();
            frm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PictureBoxTestForm frm = new PictureBoxTestForm();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TooltipTestForm frm = new TooltipTestForm();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumericUpDownTest frm = new NumericUpDownTest();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PainterForm frm = new PainterForm();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MouseEnterLeave frm = new MouseEnterLeave();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            KeyDemo frm = new KeyDemo();
            frm.Show();
        }
    }
}
