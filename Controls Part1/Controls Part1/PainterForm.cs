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
    public partial class PainterForm : Form
    {
        bool shouldPaint = false; // determines whether to paint
        public PainterForm()
        {
            InitializeComponent();
        }

        private void PainterForm_Load(object sender, EventArgs e)
        {

        }

        private void PainterForm_MouseDown(object sender, MouseEventArgs e)
        {
            // indicate that user is dragging the mouse
            shouldPaint = true;
        }

        private void PainterForm_MouseUp(object sender, MouseEventArgs e)
        {
            // indicate that user released the mouse button
            shouldPaint = false;
        }

        private void PainterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint) // check if mouse button is being pressed
            {
                // draw a circle where the mouse pointer is present
                using (Graphics graphics = CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(Color.Red), e.X, e.Y, 4, 4);
                } // end using; calls graphics.Dispose()
            } // end if
        }
    }
}
