using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TMS_FINAL;

namespace TMS_FINAL
{
    public partial class Assign_Drivers : Form
    {
        private SqlConnection con = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TransportMS;Integrated Security=True"
        );

        int selectedRowIndex = -1;

        public Assign_Drivers()
        {
            InitializeComponent();
        }

        private void Assign_Drivers_Load(object sender, EventArgs e)
        {
            LoadDriverAssignments();
            LoadDriverCombo();
            LoadRouteCombo();
            LoadVehicleTypeCombo(); // Fixed 3 options

            dgvAssignDrivers.ReadOnly = true;
            dgvAssignDrivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssignDrivers.MultiSelect = false;
        }

        // ================= LOAD DRIVER ASSIGNMENTS =================
        private void LoadDriverAssignments()
        {
            try
            {
                string query = "SELECT DriverName, VehicleType, VehicleID, Contact, Route, AssignDate FROM DriverAssignments";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAssignDrivers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading driver assignments: " + ex.Message);
            }
        }

        // ================= LOAD DRIVER COMBO =================
        private void LoadDriverCombo()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Name FROM Drivers", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbDriver.DisplayMember = "Name";
                cmbDriver.ValueMember = "Name";
                cmbDriver.DataSource = dt;
                cmbDriver.SelectedIndex = -1;

                // User must select, no typing
                cmbDriver.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading drivers: " + ex.Message);
            }
        }

        // ================= LOAD ROUTE COMBO =================
        private void LoadRouteCombo()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT ISNULL(StartPoint,'') + ' - ' + ISNULL(EndPoint,'') AS Route FROM Routes", con
                );
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbRoute.DisplayMember = "Route";
                cmbRoute.ValueMember = "Route";
                cmbRoute.DataSource = dt;
                cmbRoute.SelectedIndex = -1;

                // User must select, no typing
                cmbRoute.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading routes: " + ex.Message);
            }
        }

        // ================= LOAD VEHICLE TYPE COMBO =================
        private void LoadVehicleTypeCombo()
        {
            cmbVehicleType.Items.Clear();
            cmbVehicleType.Items.AddRange(new string[] { "Car", "Van", "Bus" });
            cmbVehicleType.SelectedIndex = -1;

            // Fixed options, no typing
            cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // ================= CLEAR FIELDS =================
        private void ClearFields()
        {
            cmbDriver.SelectedIndex = -1;
            txtVehicleNo.Clear();
            txtContactNo.Clear();
            cmbVehicleType.SelectedIndex = -1;
            cmbRoute.SelectedIndex = -1;
            Date.Value = DateTime.Now;
            selectedRowIndex = -1;
        }

        // ================= VALIDATE VEHICLE NUMBER =================
        private bool IsVehicleNumberValid(string vehicleNo)
        {
            return Regex.IsMatch(vehicleNo, @"^[A-Za-z0-9]+$");
        }

        // ================= ADD ASSIGNMENT =================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbDriver.SelectedIndex == -1 ||
                cmbVehicleType.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtVehicleNo.Text) ||
                string.IsNullOrWhiteSpace(txtContactNo.Text) ||
                cmbRoute.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (!IsVehicleNumberValid(txtVehicleNo.Text.Trim()))
            {
                MessageBox.Show("Vehicle number can only contain letters and numbers!");
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO DriverAssignments (DriverName, VehicleType, VehicleID, Contact, Route, AssignDate) " +
                    "VALUES (@driver, @type, @vid, @contact, @route, @date)", con))
                {
                    cmd.Parameters.AddWithValue("@driver", cmbDriver.Text);
                    cmd.Parameters.AddWithValue("@type", cmbVehicleType.Text);
                    cmd.Parameters.AddWithValue("@vid", txtVehicleNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", txtContactNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@route", cmbRoute.Text);
                    cmd.Parameters.AddWithValue("@date", Date.Value.Date);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Driver assigned successfully!");
                    LoadDriverAssignments();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error adding driver assignment: " + ex.Message);
            }
        }

        // ================= UPDATE ASSIGNMENT =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex == -1)
            {
                MessageBox.Show("Select a row to update.");
                return;
            }

            if (cmbVehicleType.SelectedIndex == -1 ||
                !IsVehicleNumberValid(txtVehicleNo.Text.Trim()))
            {
                MessageBox.Show("Please select a valid vehicle type and check vehicle number!");
                return;
            }

            try
            {
                DataGridViewRow row = dgvAssignDrivers.Rows[selectedRowIndex];
                string oldDriverName = row.Cells["DriverName"].Value.ToString();
                string oldVehicleID = row.Cells["VehicleID"].Value.ToString();

                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE DriverAssignments SET DriverName=@driver, VehicleType=@type, VehicleID=@vid, Contact=@contact, Route=@route, AssignDate=@date " +
                    "WHERE DriverName=@oldDriver AND VehicleID=@oldVehicle", con))
                {
                    cmd.Parameters.AddWithValue("@driver", cmbDriver.Text);
                    cmd.Parameters.AddWithValue("@type", cmbVehicleType.Text);
                    cmd.Parameters.AddWithValue("@vid", txtVehicleNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", txtContactNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@route", cmbRoute.Text);
                    cmd.Parameters.AddWithValue("@date", Date.Value.Date);
                    cmd.Parameters.AddWithValue("@oldDriver", oldDriverName);
                    cmd.Parameters.AddWithValue("@oldVehicle", oldVehicleID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Driver assignment updated successfully!");
                    LoadDriverAssignments();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error updating driver assignment: " + ex.Message);
            }
        }

        // ================= DELETE ASSIGNMENT =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex == -1)
            {
                MessageBox.Show("Select a row to delete.");
                return;
            }

            try
            {
                DataGridViewRow row = dgvAssignDrivers.Rows[selectedRowIndex];
                string driverName = row.Cells["DriverName"].Value.ToString();
                string vehicleID = row.Cells["VehicleID"].Value.ToString();

                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM DriverAssignments WHERE DriverName=@driver AND VehicleID=@vid", con))
                {
                    cmd.Parameters.AddWithValue("@driver", driverName);
                    cmd.Parameters.AddWithValue("@vid", vehicleID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Driver assignment deleted successfully!");
                    LoadDriverAssignments();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error deleting driver assignment: " + ex.Message);
            }
        }

        // ================= SELECT ROW =================
        private void dgvAssignDrivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dgvAssignDrivers.Rows[selectedRowIndex];

            cmbDriver.Text = row.Cells["DriverName"].Value.ToString();
            txtVehicleNo.Text = row.Cells["VehicleID"].Value.ToString();
            txtContactNo.Text = row.Cells["Contact"].Value.ToString();
            cmbRoute.Text = row.Cells["Route"].Value.ToString();
            cmbVehicleType.Text = row.Cells["VehicleType"].Value.ToString();
            Date.Value = Convert.ToDateTime(row.Cells["AssignDate"].Value);
        }

        // ================= CLEAR BUTTON =================
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }


        // ================= NAVIGATION BUTTONS =================
        private void btnAssignVehicles_Click(object sender, EventArgs e)
        {
            Assign_Vehicles form = new Assign_Vehicles();
            form.Show();
            this.Hide();
        }

        private void btnAssignDrivers_Click(object sender, EventArgs e)
        {
            Assign_Drivers form = new Assign_Drivers();
            form.Show();
            this.Hide();
        }

        private void btnGenerateBills_Click(object sender, EventArgs e)
        {
            Generate_Bills form = new Generate_Bills();
            form.Show();
            this.Hide();
        }

        private void btnViewRecords_Click(object sender, EventArgs e)
        {
            View_Records form = new View_Records();
            form.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void cmbRoute_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}