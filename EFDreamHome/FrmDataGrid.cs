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
    public partial class FrmDataGrid : Form
    {
        Model1Container ThisContainer;
        public FrmDataGrid()
        {
            InitializeComponent();
            ThisContainer = new Model1Container();
            
        }

        private void FrmDataGrid_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ThisContainer.Staffs.ToList();           
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ThisContainer.SaveChanges();
            MessageBox.Show("Data Updated");
        }
    }
}
