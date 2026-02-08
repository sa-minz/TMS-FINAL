using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS_FINAL
{
    public partial class Staff_Dashboard : Form
    {
        public Staff_Dashboard()
        {
            InitializeComponent();
        }


        private void btnAssign_Click(object sender, EventArgs e)
        {
            Assign_Vehicles assignVehicleForm = new Assign_Vehicles();
            assignVehicleForm.Show();
            this.Hide();
        }

        private void btnAssignDriver_Click(object sender, EventArgs e)
        {
            Assign_Drivers assignDriverForm = new Assign_Drivers();
            assignDriverForm.Show();
            this.Hide();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            Generate_Bills generateBillsForm = new Generate_Bills();
            generateBillsForm.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            View_Reports viewReportsForm = new View_Reports();
            viewReportsForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
