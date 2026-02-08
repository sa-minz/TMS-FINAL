using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace TMS_FINAL
{
    public partial class Manage_Drivers : Form
    {
        // SQL Server connection
        private SqlConnection con = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TransportMS;Integrated Security=True"
        );

        int selectedDriverId = -1; // store selected driver ID

        public Manage_Drivers()
        {
            InitializeComponent();
        }

        private void Manage_Drivers_Load(object sender, EventArgs e)
        {
            LoadDrivers();
            dgvManageDrivers.ReadOnly = true;                  // prevent direct editing
            dgvManageDrivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvManageDrivers.MultiSelect = false;
        }

        // ================= LOAD DRIVERS =================
        private void LoadDrivers()
        {
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT DriverID, Name, License, Contact, DOB, Address FROM Drivers", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvManageDrivers.DataSource = dt;

                    dgvManageDrivers.Columns["DriverID"].Visible = false; // hide PK
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading drivers: " + ex.Message);
            }
        }

        // ================= CLEAR FIELDS =================
        private void ClearFields()
        {
            txtDriverName.Clear();
            txtLicenseNo.Clear();
            txtContact.Clear();
            DOB.Value = DateTime.Now; // assuming you have a DateTimePicker for DOB
            txtAddress.Clear();
            selectedDriverId = -1;
        }

        // ================= ADD DRIVER =================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDriverName.Text) ||
                string.IsNullOrWhiteSpace(txtLicenseNo.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Drivers (Name, License, Contact, DOB, Address) VALUES (@name, @license, @contact, @dob, @address)", con))
                {
                    cmd.Parameters.AddWithValue("@name", txtDriverName.Text.Trim());
                    cmd.Parameters.AddWithValue("@license", txtLicenseNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
                    cmd.Parameters.AddWithValue("@dob", DOB.Value.Date);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Driver added successfully!");
                    LoadDrivers();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error adding driver: " + ex.Message);
            }
        }

        // ================= UPDATE DRIVER =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedDriverId == -1)
            {
                MessageBox.Show("Select a driver to update.");
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE Drivers SET Name=@name, License=@license, Contact=@contact, DOB=@dob, Address=@address WHERE DriverID=@id", con))
                {
                    cmd.Parameters.AddWithValue("@name", txtDriverName.Text.Trim());
                    cmd.Parameters.AddWithValue("@license", txtLicenseNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
                    cmd.Parameters.AddWithValue("@dob", DOB.Value.Date);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", selectedDriverId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Driver updated successfully!");
                    LoadDrivers();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error updating driver: " + ex.Message);
            }
        }

        // ================= DELETE DRIVER =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedDriverId == -1)
            {
                MessageBox.Show("Select a driver to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this driver?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Drivers WHERE DriverID=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedDriverId);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Driver deleted successfully!");
                        LoadDrivers();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("Error deleting driver: " + ex.Message);
                }
            }
        }

        // ================= SELECT DRIVER =================
        private void dgvManageDrivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvManageDrivers.Rows[e.RowIndex];

            try
            {
                selectedDriverId = Convert.ToInt32(row.Cells["DriverID"].Value);
                txtDriverName.Text = row.Cells["Name"].Value.ToString();
                txtLicenseNo.Text = row.Cells["License"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();
                DOB.Value = Convert.ToDateTime(row.Cells["DOB"].Value);
                txtAddress.Text = row.Cells["Address"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting driver: " + ex.Message);
            }
        }

        // ================= CLEAR BUTTON =================
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }


        
        // ================= NAVIGATION BUTTONS =================
        private void btnUser_Click(object sender, EventArgs e)
        {
            // Open Manage_Users form and close current form
            Manage_Users usersForm = new Manage_Users();
            usersForm.Show();
            this.Close();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            Manage_Vehicles vehiclesForm = new Manage_Vehicles();
            vehiclesForm.Show();
            this.Close();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
           
            LoadDrivers();
        }

        private void btnRoutes_Click(object sender, EventArgs e)
        {
            Manage_Routes routesForm = new Manage_Routes();
            routesForm.Show();
            this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            View_Reports reportsForm = new View_Reports();
            reportsForm.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close(); // Closes current form and shows login
        }
    }
}
