using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TMS_FINAL
{
    public partial class View_Records : Form
    {
        private SqlConnection con = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TransportMS;Integrated Security=True"
        );

        public View_Records()
        {
            InitializeComponent();
        }

        // ================= FORM LOAD =================
        private void View_Records_Load(object sender, EventArgs e)
        {
            cmbType.Items.Clear();
            cmbType.Items.Add("Assigned Driver");
            cmbType.Items.Add("Assigned Vehicle");

            FromDate.Value = DateTime.Now.AddDays(-30); // default last 30 days
            ToDate.Value = DateTime.Now;
        }

        // ================= SEARCH RECORDS =================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a type (Driver or Vehicle).");
                return;
            }

            try
            {
                con.Open();
                string query = "";

                if (cmbType.SelectedItem.ToString() == "Assigned Driver")
                {
                    // DriverAssignments table
                    query = @"SELECT DriverName, VehicleType, VehicleID, Contact, Route, AssignDate
                              FROM DriverAssignments
                              WHERE AssignDate BETWEEN @startDate AND @endDate";
                }
                else if (cmbType.SelectedItem.ToString() == "Assigned Vehicle")
                {
                    // VehicleAssignments table
                    query = @"SELECT VehicleID, AssignDate, VehicleType, Route
                              FROM VehicleAssignments
                              WHERE AssignDate BETWEEN @startDate AND @endDate";
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@startDate", FromDate.Value.Date);
                    cmd.Parameters.AddWithValue("@endDate", ToDate.Value.Date);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No records found in the selected date range.");
                        dgvViewRecords.DataSource = null; // clear previous data
                    }
                    else
                    {
                        dgvViewRecords.DataSource = dt;
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records: " + ex.Message);
                con.Close();
            }
        }

        // ================= CLEAR BUTTON =================
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvViewRecords.DataSource = null;
            cmbType.SelectedIndex = -1;
            FromDate.Value = DateTime.Now.AddDays(-30);
            ToDate.Value = DateTime.Now;
        }

        // ================= EXPORT TO CSV =================
        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (dgvViewRecords.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV Files (*.csv)|*.csv";
            sfd.FileName = "Assignments.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName))
                    {
                        // Write headers
                        for (int i = 0; i < dgvViewRecords.Columns.Count; i++)
                        {
                            writer.Write(dgvViewRecords.Columns[i].HeaderText);
                            if (i < dgvViewRecords.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();

                        // Write rows
                        foreach (DataGridViewRow row in dgvViewRecords.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dgvViewRecords.Columns.Count; i++)
                                {
                                    string value = row.Cells[i].Value?.ToString().Replace(",", " ") ?? "";
                                    writer.Write(value);
                                    if (i < dgvViewRecords.Columns.Count - 1)
                                        writer.Write(",");
                                }
                                writer.WriteLine();
                            }
                        }
                    }

                    MessageBox.Show("Records exported successfully!");
                }
                catch (IOException ioEx)
                {
                    MessageBox.Show("File error: " + ioEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error: " + ex.Message);
                }
            }
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

        private void btnGenerateBill_Click(object sender, EventArgs e)
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

        private void lblViewRecords_Click(object sender, EventArgs e)
        {

        }
    }
}