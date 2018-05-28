using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDreamHome
{
    public partial class FrmStaff : Form
    {
        Model1Container ThisContainer;
        
        public FrmStaff()
        {
            InitializeComponent();
            // create container object
            ThisContainer = new Model1Container();
            
        }
        private void setClear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
        }
      
        private void btnCount_Click(object sender, EventArgs e)
        {
            // Display the number of database records.
           MessageBox.Show("There are " +
            ThisContainer.Staffs.Count().ToString() + 
            " Records.");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create a new record.
            Staff ThisStaff = ThisContainer.Staffs.Create();

            // Add some data
            ThisStaff.fName = txtFirstName.Text;
            ThisStaff.lName = txtLastName.Text;

            // Add a new record.
            ThisContainer.Staffs.Add(ThisStaff);
            ThisContainer.SaveChanges();
            
            // Inform the user.
            MessageBox.Show("Added " + ThisStaff.Id.ToString());

            // clear Text Box
            setClear();

        }

        private void FrmStaff_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Staff ThisStaff = ThisContainer.Staffs.First();
            ThisContainer.Staffs.Remove(ThisStaff);
            ThisContainer.SaveChanges();
            MessageBox.Show("Record Removed");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
