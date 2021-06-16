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
    public partial class CheckBoxTestForm : Form
    {
        public CheckBoxTestForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            messageDisplay.Text = checkBox1.Checked.ToString();
            //messageDisplay2.Text = checkBox1.CheckState.ToString();
        }

        private void CheckBoxTestForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            messageDisplay2.Text = checkBox1.CheckState.ToString();
        }

        private void boldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // x ^ y	Boolean logical XOR
            // 0 0  0
            // 1 0  1
            // 0 1  1
            // 1 1  0

            outputLabel.Font = new Font(outputLabel.Font, outputLabel.Font.Style ^ FontStyle.Bold);

        }

        private void italicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Font = new Font(outputLabel.Font, outputLabel.Font.Style ^ FontStyle.Italic);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)

                MessageBox.Show("checkbox selected/checked");
            else
                MessageBox.Show("checkbox unselected/unchecked");
        }

    }
}
