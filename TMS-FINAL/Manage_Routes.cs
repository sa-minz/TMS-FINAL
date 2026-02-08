using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace TMS_FINAL
{
    public partial class Manage_Routes : Form
    {
        // SQL Server connection
        private SqlConnection con = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TransportMS;Integrated Security=True"
        );

        int selectedRouteId = -1; // store selected route ID

        public Manage_Routes()
        {
            InitializeComponent();
        }

        private void Manage_Routes_Load(object sender, EventArgs e)
        {
            LoadRoutes();
            dgvManageRoutes.ReadOnly = true;                   // prevent direct editing
            dgvManageRoutes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvManageRoutes.MultiSelect = false;
        }

        // ================= LOAD ROUTES =================
        private void LoadRoutes()
        {
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT RouteID, StartPoint, EndPoint, Distance, RouteDate FROM Routes", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvManageRoutes.DataSource = dt;

                    dgvManageRoutes.Columns["RouteID"].Visible = false; // hide PK
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading routes: " + ex.Message);
            }
        }

        // ================= CLEAR FIELDS =================
        private void ClearFields()
        {
            txtStart.Clear();
            txtEnd.Clear();
            txtDistance.Clear();
            Date.Value = DateTime.Now;
            selectedRouteId = -1;
        }

        // ================= ADD ROUTE =================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStart.Text) ||
                string.IsNullOrWhiteSpace(txtEnd.Text) ||
                string.IsNullOrWhiteSpace(txtDistance.Text))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Routes (StartPoint, EndPoint, Distance, RouteDate) VALUES (@start, @end, @distance, @rdate)", con))
                {
                    cmd.Parameters.AddWithValue("@start", txtStart.Text.Trim());
                    cmd.Parameters.AddWithValue("@end", txtEnd.Text.Trim());
                    cmd.Parameters.AddWithValue("@distance", txtDistance.Text.Trim());
                    cmd.Parameters.AddWithValue("@rdate", Date.Value.Date);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Route added successfully!");
                    LoadRoutes();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error adding route: " + ex.Message);
            }
        }

        // ================= UPDATE ROUTE =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRouteId == -1)
            {
                MessageBox.Show("Select a route to update.");
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE Routes SET StartPoint=@start, EndPoint=@end, Distance=@distance, RouteDate=@rdate WHERE RouteID=@id", con))
                {
                    cmd.Parameters.AddWithValue("@start", txtStart.Text.Trim());
                    cmd.Parameters.AddWithValue("@end", txtEnd.Text.Trim());
                    cmd.Parameters.AddWithValue("@distance", txtDistance.Text.Trim());
                    cmd.Parameters.AddWithValue("@rdate", Date.Value.Date);
                    cmd.Parameters.AddWithValue("@id", selectedRouteId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Route updated successfully!");
                    LoadRoutes();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error updating route: " + ex.Message);
            }
        }

        // ================= DELETE ROUTE =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRouteId == -1)
            {
                MessageBox.Show("Select a route to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this route?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Routes WHERE RouteID=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedRouteId);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Route deleted successfully!");
                        LoadRoutes();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("Error deleting route: " + ex.Message);
                }
            }
        }

        // ================= SELECT ROUTE =================
        private void dgvRoutes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvManageRoutes.Rows[e.RowIndex];

            try
            {
                selectedRouteId = Convert.ToInt32(row.Cells["RouteID"].Value);
                txtStart.Text = row.Cells["StartPoint"].Value.ToString();
                txtEnd.Text = row.Cells["EndPoint"].Value.ToString();
                txtDistance.Text = row.Cells["Distance"].Value.ToString();
                Date.Value = Convert.ToDateTime(row.Cells["RouteDate"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting route: " + ex.Message);
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
