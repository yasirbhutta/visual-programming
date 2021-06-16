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
    public partial class RadioButtonsTestForm : Form
    {

        private MessageBoxIcon iconType;

        private MessageBoxButtons buttonType;

        public RadioButtonsTestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "This is your Custom MessageBox.", "Custon MessageBox",buttonType, iconType);
        }

        private void buttonType_CheckedChanged(object sender, EventArgs e)
        {

            if (sender == okRadioButton) // display OK Button
                buttonType = MessageBoxButtons.OK;

            // display OK and Cancel Buttons
            else if (sender == okCancelRadioButton)
                buttonType = MessageBoxButtons.OKCancel;

        }

        private void iconType_CheckedChanged(object sender, EventArgs e)
 {
         if (sender == asteriskRadioButton ) // display asterisk Icon
          iconType = MessageBoxIcon.Asterisk;

 // display error Icon
          else if (sender == errorRadioButton )
              iconType = MessageBoxIcon.Error;
            }

        private void RadioButtonsTestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
