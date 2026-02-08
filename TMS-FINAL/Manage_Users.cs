using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TMS_FINAL
{
    public partial class Manage_Users : Form
    {
        // SQL Server connection
        private SqlConnection con = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TransportMS;Integrated Security=True"
        );

        int selectedUserId = -1; // store selected user ID

        public Manage_Users()
        {
            InitializeComponent();
        }

        private void Manage_Users_Load(object sender, EventArgs e)
        {
            LoadUsers();
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
        }

        // ================= LOAD USERS =================
        private void LoadUsers()
        {
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT UserID, Name, Username, Password, Role FROM dbo.Users", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUsers.DataSource = dt;

                    dgvUsers.Columns["UserID"].Visible = false; // hide ID column
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        // ================= CLEAR FIELDS =================
        private void ClearFields()
        {
            txtName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cbRole.SelectedIndex = -1;
            selectedUserId = -1;
        }

        // ================= ADD USER =================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(cbRole.Text))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Users (Name, Username, Password, Role) VALUES (@name, @username, @password, @role)", con))
                {
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@role", cbRole.Text.Trim());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("User added successfully!");
                    LoadUsers();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error adding user: " + ex.Message);
            }
        }

        // ================= UPDATE USER =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Select a user to update.");
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE Users SET Name=@name, Username=@username, Password=@password, Role=@role WHERE UserID=@id", con))
                {
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@role", cbRole.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", selectedUserId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("User updated successfully!");
                    LoadUsers();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }

        // ================= DELETE USER =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Select a user to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserID=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedUserId);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("User deleted successfully!");
                        LoadUsers();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("Error deleting user: " + ex.Message);
                }
            }
        }

        // ================= CELLCLICK TO SELECT USER =================
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

            try
            {
                selectedUserId = Convert.ToInt32(row.Cells["UserID"].Value);
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                cbRole.Text = row.Cells["Role"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting user: " + ex.Message);
            }
        }

        // ================= CLEAR BUTTON =================
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // ================= NAVIGATION BUTTONS =================
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
