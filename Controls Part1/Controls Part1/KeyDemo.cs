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
    public partial class KeyDemo : Form
    {
        public KeyDemo()
        {
            InitializeComponent();
        }

        private void KeyDemo_KeyPress(object sender, KeyPressEventArgs e)
        {
            charLabel.Text = "Key pressed: " + e.KeyChar;
        }

        // display modifier keys, key code, key data and key value
        private void KeyDemo_KeyDown(object sender, KeyEventArgs e)
        {
            keyInfoLabel.Text =
                                "Alt: " + (e.Alt ? "Yes" : "No") + '\n' +
                                "Shift: " + (e.Shift ? "Yes" : "No") + '\n' +
                                "Ctrl: " + (e.Control ? "Yes" : "No") + '\n' +
                                "KeyCode: " + e.KeyCode + '\n' +
                                "KeyData: " + e.KeyData + '\n' +
                                 "KeyValue: " + e.KeyValue;
            if (e.Control == true && e.KeyCode == Keys.R)
                this.BackColor = Color.Red;
            else if (e.Control == true && e.KeyCode == Keys.G)
                this.BackColor = Color.Green;
            else
                this.BackColor = Color.White;
        }

        private void KeyDemo_KeyUp(object sender, KeyEventArgs e)
        {
            charLabel.Text = "";
            keyInfoLabel.Text = "";
        }
    }
}
