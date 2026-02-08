using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace TMS_FINAL
{
    public partial class Manage_Vehicles : Form
    {
        // SQL Server connection
        private SqlConnection con = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TransportMS;Integrated Security=True"
        );

        int selectedVehicleId = -1; // store selected Vehicle ID (assuming Vehicles table has VehicleID as PK)

        public Manage_Vehicles()
        {
            InitializeComponent();
        }

        private void Manage_Vehicles_Load(object sender, EventArgs e)
        {
            LoadVehicles();
            dgvVehicles.ReadOnly = true;
            dgvVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehicles.MultiSelect = false;
        }

        // ================= LOAD VEHICLES =================
        private void LoadVehicles()
        {
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT VehicleID, VehicleNumber, Type, Capacity FROM Vehicles", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvVehicles.DataSource = dt;

                    dgvVehicles.Columns["VehicleID"].Visible = false; // hide PK
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicles: " + ex.Message);
            }
        }

        // ================= CLEAR FIELDS =================
        private void ClearFields()
        {
            txtVehicleNo.Clear();
            cmbVehicleType.SelectedIndex = -1;
            txtCapacity.Clear();
            selectedVehicleId = -1;
        }

        // ================= ADD VEHICLE =================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVehicleNo.Text) ||
                string.IsNullOrWhiteSpace(cmbVehicleType.Text) ||
                string.IsNullOrWhiteSpace(txtCapacity.Text))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Vehicles (VehicleNumber, Type, Capacity) VALUES (@vno, @type, @cap)", con))
                {
                    cmd.Parameters.AddWithValue("@vno", txtVehicleNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@type", cmbVehicleType.Text.Trim());
                    cmd.Parameters.AddWithValue("@cap", txtCapacity.Text.Trim());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Vehicle added successfully!");
                    LoadVehicles();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error adding vehicle: " + ex.Message);
            }
        }

        // ================= UPDATE VEHICLE =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedVehicleId == -1)
            {
                MessageBox.Show("Select a vehicle to update.");
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE Vehicles SET VehicleNumber=@vno, Type=@type, Capacity=@cap WHERE VehicleID=@id", con))
                {
                    cmd.Parameters.AddWithValue("@vno", txtVehicleNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@type", cmbVehicleType.Text.Trim());
                    cmd.Parameters.AddWithValue("@cap", txtCapacity.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", selectedVehicleId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Vehicle updated successfully!");
                    LoadVehicles();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error updating vehicle: " + ex.Message);
            }
        }

        // ================= DELETE VEHICLE =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedVehicleId == -1)
            {
                MessageBox.Show("Select a vehicle to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this vehicle?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Vehicles WHERE VehicleID=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedVehicleId);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Vehicle deleted successfully!");
                        LoadVehicles();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("Error deleting vehicle: " + ex.Message);
                }
            }
        }

        // ================= SELECT VEHICLE =================
        private void dgvVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvVehicles.Rows[e.RowIndex];

            try
            {
                selectedVehicleId = Convert.ToInt32(row.Cells["VehicleID"].Value);
                txtVehicleNo.Text = row.Cells["VehicleNumber"].Value.ToString();
                cmbVehicleType.Text = row.Cells["Type"].Value.ToString();
                txtCapacity.Text = row.Cells["Capacity"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting vehicle: " + ex.Message);
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
            Manage_Drivers driversForm = new Manage_Drivers();
            driversForm.Show();
            this.Close();
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
            this.Close();
        }
    }
}
