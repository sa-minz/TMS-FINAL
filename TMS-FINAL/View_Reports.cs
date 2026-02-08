using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TMS_FINAL
{
    public partial class View_Reports : Form
    {
        private SqlConnection con = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TransportMS;Integrated Security=True"
        );

        public View_Reports()
        {
            InitializeComponent();
        }

        // ================= NAVIGATION BUTTONS =================

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Manage_Users usersForm = new Manage_Users();
            usersForm.Show();
            this.Hide();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            Manage_Vehicles vehiclesForm = new Manage_Vehicles();
            vehiclesForm.Show();
            this.Hide();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            Manage_Drivers d = new Manage_Drivers();
            d.Show();
            this.Hide();
        }

        private void btnRoutes_Click(object sender, EventArgs e)
        {
            Manage_Routes routesForm = new Manage_Routes();
            routesForm.Show();
            this.Hide();
        }

        // ================= FORM LOAD =================

        private void ViewReports_Load(object sender, EventArgs e)
        {
            cmbReportType.Items.Clear();
            cmbReportType.Items.Add("user");
            cmbReportType.Items.Add("driver");
            cmbReportType.Items.Add("vehicle");
            cmbReportType.Items.Add("route");
        }

        // ================= LOAD REPORT =================

        private void LoadReport()
        {
            if (cmbReportType.SelectedIndex == -1)
                return;

            string tableName = cmbReportType.SelectedItem.ToString();

            try
            {
                con.Open();
                string query = $"SELECT * FROM {tableName}";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvViewReports.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message);
                con.Close();
            }
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReport();
        }

        // ================= FILE HANDLING - EXPORT CSV =================

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvViewReports.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV Files (*.csv)|*.csv";
            sfd.FileName = "Report.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Use proper file handling with 'using' and exception handling
                    using (StreamWriter writer = new StreamWriter(sfd.FileName))
                    {
                        // Write column headers
                        for (int i = 0; i < dgvViewReports.Columns.Count; i++)
                        {
                            writer.Write(dgvViewReports.Columns[i].HeaderText);
                            if (i < dgvViewReports.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();

                        // Write rows
                        foreach (DataGridViewRow row in dgvViewReports.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dgvViewReports.Columns.Count; i++)
                                {
                                    string value = row.Cells[i].Value?.ToString().Replace(",", " ") ?? "";
                                    writer.Write(value);
                                    if (i < dgvViewReports.Columns.Count - 1)
                                        writer.Write(",");
                                }
                                writer.WriteLine();
                            }
                        }
                    }

                    MessageBox.Show("Report exported successfully!");
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

        private void View_Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
