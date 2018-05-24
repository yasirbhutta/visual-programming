using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthCalendar
{
    public partial class FrmMonthCalendar : Form
    {
        private System.Windows.Forms.TextBox textBox1;
        public FrmMonthCalendar()
        {
            InitializeComponent();

            //
            // draw TextBox
            //
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(48, 488);
            this.textBox1.Multiline = true;
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(824, 32);
            //
            //
            // dates selection
            //
            monthCalendar1.SelectionStart = new System.DateTime(2018, 5, 26);
            monthCalendar1.SelectionEnd = new System.DateTime(2018, 5, 31);
            // Add dates to MonthlyBoldedDates array.
            this.monthCalendar1.MonthlyBoldedDates =
               new System.DateTime[] {new System.DateTime(2002, 1, 15, 0, 0, 0, 0),
                                  new System.DateTime(2002, 1, 30, 0, 0, 0, 0)};

                      // Set week to begin on Monday.
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;

            // Set the maximum visible date on the calendar to 12/31/2010.
            this.monthCalendar1.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);

            // Set the minimum visible date on calendar to 12/31/2010.
            this.monthCalendar1.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);

            // Only allow 21 days to be selected at the same time.
            this.monthCalendar1.MaxSelectionCount = 10;

            // Set the calendar to move one month at a time when navigating using the arrows.
            this.monthCalendar1.ScrollChange = 1;

            // Do not show the "Today" banner.
            this.monthCalendar1.ShowToday = false;

            // Show the week numbers to the left of each week.
            this.monthCalendar1.ShowWeekNumbers = true;

            // Set up how the form should be displayed and add the TextBox control to the form.
            this.ClientSize = new System.Drawing.Size(920, 566);
            this.Controls.Add(this.textBox1);
            this.Text = "Month Calendar Example";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Show the start and end dates in the text box.
            this.textBox1.Text = "Date Changed: Start =  " +
                e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString();
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Show the start and end dates in the text box.
            this.textBox1.Text = "Date Selected: Start = " +
                e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString();
        }
    }
}
