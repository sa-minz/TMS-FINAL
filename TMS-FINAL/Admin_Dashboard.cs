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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        // Manage Users
        private void btnUser_Click(object sender, EventArgs e)
        {

            Manage_Users UserForm = new Manage_Users();
            UserForm.Show();
            this.Hide();
        }


        // Manage Vehicles
        private void btnVehicles_Click(object sender, EventArgs e)
        {
            Manage_Vehicles vehiclesForm = new Manage_Vehicles();
            vehiclesForm.Show();
            this.Hide();
        }

        // Manage Drivers
        private void btnDrivers_Click(object sender, EventArgs e)
        {
            Manage_Drivers driversForm = new Manage_Drivers();
            driversForm.Show();
            this.Hide();
        }

        // Manage Routes
        private void btnRoutes_Click(object sender, EventArgs e)
        {
            Manage_Routes routesForm = new Manage_Routes();
            routesForm.Show();
            this.Hide();
        }

        // View Reports
        private void btnViewReports_Click(object sender, EventArgs e)
        {
            View_Reports reportsForm = new View_Reports();
            reportsForm.Show();
            this.Hide();
        }

        // Logout

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        
    }
}

