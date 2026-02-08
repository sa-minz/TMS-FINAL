using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace TMS_FINAL
{
    public partial class Assign_Vehicles : Form
    {
        private SqlConnection con = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TransportMS;Integrated Security=True"
        );

        int selectedRowIndex = -1; // track selected row in DataGridView

        public Assign_Vehicles()
        {
            InitializeComponent();
        }

        private void Assign_Vehicles_Load(object sender, EventArgs e)
        {
            LoadAssignments();
            LoadVehicleTypeCombo();
            LoadRouteCombo();

            dgvAssignVehicles.ReadOnly = true;
            dgvAssignVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssignVehicles.MultiSelect = false;
        }

        // ================= LOAD ASSIGNMENTS =================
        private void LoadAssignments()
        {
            try
            {
                string query = "SELECT VehicleType, VehicleNumber, Route, AssignDate FROM VehicleAssignment";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAssignVehicles.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assignments: " + ex.Message);
            }
        }

        // ================= LOAD VEHICLE TYPE COMBO =================
        private void LoadVehicleTypeCombo()
        {
            // Fixed options, since you want Car, Van, Bus
            cmbVehicleType.Items.Clear();
            cmbVehicleType.Items.AddRange(new string[] { "Car", "Van", "Bus" });
            cmbVehicleType.SelectedIndex = -1;
        }

        // ================= LOAD ROUTE COMBO =================
        private void LoadRouteCombo()
        {
            // Fixed routes example
            cmbRoute.Items.Clear();
            cmbRoute.Items.AddRange(new string[]
            {
                "Colombo-Kandy",
                "Colombo-Galle",
                "Nuwara Eliya-Colombo"
            });
            cmbRoute.SelectedIndex = -1;
        }

        // ================= CLEAR FIELDS =================
        private void ClearFields()
        {
            cmbVehicleType.SelectedIndex = -1;
            txtVehicleNo.Clear();
            cmbRoute.SelectedIndex = -1;
            Date.Value = DateTime.Now;
            selectedRowIndex = -1;
        }

        // ================= ADD ASSIGNMENT =================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbVehicleType.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtVehicleNo.Text) || cmbRoute.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO VehicleAssignment (VehicleType, VehicleNumber, Route, AssignDate) VALUES (@type, @number, @route, @date)", con))
                {
                    cmd.Parameters.AddWithValue("@type", cmbVehicleType.Text.Trim());
                    cmd.Parameters.AddWithValue("@number", txtVehicleNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@route", cmbRoute.Text.Trim());
                    cmd.Parameters.AddWithValue("@date", Date.Value.Date);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Vehicle assigned successfully!");
                    LoadAssignments();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error adding assignment: " + ex.Message);
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

            try
            {
                DataGridViewRow row = dgvAssignVehicles.Rows[selectedRowIndex];
                string oldVehicleNumber = row.Cells["VehicleNumber"].Value.ToString();

                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE VehicleAssignment SET VehicleType=@type, VehicleNumber=@number, Route=@route, AssignDate=@date WHERE VehicleNumber=@oldNumber", con))
                {
                    cmd.Parameters.AddWithValue("@type", cmbVehicleType.Text.Trim());
                    cmd.Parameters.AddWithValue("@number", txtVehicleNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@route", cmbRoute.Text.Trim());
                    cmd.Parameters.AddWithValue("@date", Date.Value.Date);
                    cmd.Parameters.AddWithValue("@oldNumber", oldVehicleNumber);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Assignment updated successfully!");
                    LoadAssignments();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error updating assignment: " + ex.Message);
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

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this assignment?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow row = dgvAssignVehicles.Rows[selectedRowIndex];
                    string vehicleNumber = row.Cells["VehicleNumber"].Value.ToString();

                    using (SqlCommand cmd = new SqlCommand(
                        "DELETE FROM VehicleAssignment WHERE VehicleNumber=@number", con))
                    {
                        cmd.Parameters.AddWithValue("@number", vehicleNumber);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Assignment deleted successfully!");
                        LoadAssignments();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("Error deleting assignment: " + ex.Message);
                }
            }
        }

        // ================= SELECT ROW =================
        private void dgvAssignVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dgvAssignVehicles.Rows[selectedRowIndex];

            try
            {
                cmbVehicleType.Text = row.Cells["VehicleType"].Value.ToString();
                txtVehicleNo.Text = row.Cells["VehicleNumber"].Value.ToString();
                cmbRoute.Text = row.Cells["Route"].Value.ToString();
                Date.Value = Convert.ToDateTime(row.Cells["AssignDate"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting row: " + ex.Message);
            }
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

       
    }
}
