using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace TMS_FINAL
{
    public partial class Generate_Bills : Form
    {
        private SqlConnection con = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TransportMS;Integrated Security=True"
        );

        private DataTable dtBills = new DataTable();
        private DataTable dtRoutes = new DataTable(); // store RouteID and Name

        public Generate_Bills()
        {
            InitializeComponent();

            txtDistance.TextChanged += TxtDistanceOrRate_TextChanged;
            txtRate.TextChanged += TxtDistanceOrRate_TextChanged;
        }

        private void Generate_Bills_Load(object sender, EventArgs e)
        {
            LoadVehicleTypeCombo();
            LoadRouteCombo();
            InitializeDataGrid();
            BillDate.Value = DateTime.Now;
        }

        // ================= LOAD VEHICLE TYPES =================
        private void LoadVehicleTypeCombo()
        {
            cmbVehicleType.Items.Clear();
            cmbVehicleType.Items.AddRange(new string[] { "Car", "Van", "Bus" });
            cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicleType.SelectedIndex = 0;
        }

        // ================= LOAD ROUTES =================
        private void LoadRouteCombo()
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT RouteID, ISNULL(StartPoint,'') + ' - ' + ISNULL(EndPoint,'') AS RouteName FROM Routes", con
                );
                dtRoutes.Clear();
                da.Fill(dtRoutes);

                cmbRoute.Items.Clear();
                foreach (DataRow row in dtRoutes.Rows)
                {
                    cmbRoute.Items.Add(row["RouteName"].ToString());
                }

                if (cmbRoute.Items.Count > 0)
                    cmbRoute.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading routes: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // ================= INITIALIZE DATAGRID =================
        private void InitializeDataGrid()
        {
            if (dtBills.Columns.Count == 0)
            {
                dtBills.Columns.Add("Type");
                dtBills.Columns.Add("RouteName");
                dtBills.Columns.Add("BillDate");
                dtBills.Columns.Add("Distance");
                dtBills.Columns.Add("RatePerKM");
                dtBills.Columns.Add("Total");

                dgvGenerateBill.DataSource = dtBills;
                dgvGenerateBill.ReadOnly = true;
                dgvGenerateBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }


        // ================= AUTO-CALCULATE TOTAL =================
        private void TxtDistanceOrRate_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDistance.Text, out decimal distance) &&
                decimal.TryParse(txtRate.Text, out decimal rate))
            {
                txtTotal.Text = (distance * rate).ToString("F2");
            }
            else
            {
                txtTotal.Text = "";
            }
        }

        // ================= ADD BILL TO DATAGRID =================
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cmbVehicleType.SelectedIndex == -1 || cmbRoute.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtDistance.Text) || string.IsNullOrWhiteSpace(txtRate.Text) ||
                string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                MessageBox.Show("Please fill all fields correctly.");
                return;
            }

            dtBills.Rows.Add(
                cmbVehicleType.SelectedItem.ToString(),
                cmbRoute.SelectedItem.ToString(),
                BillDate.Value.ToString("yyyy-MM-dd"),
                txtDistance.Text,
                txtRate.Text,
                txtTotal.Text
            );
        }

        // ================= GENERATE BILLS IN DATABASE =================
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (dtBills.Rows.Count == 0)
            {
                MessageBox.Show("No bills to generate.");
                return;
            }

            try
            {
                con.Open();
                foreach (DataRow row in dtBills.Rows)
                {
                    // Find RouteID from dtRoutes using selected RouteName
                    int routeID = Convert.ToInt32(dtRoutes.Select($"RouteName = '{row["RouteName"]}'")[0]["RouteID"]);

                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Bills (Type, RouteID, BillDate, Distance, RatePerKM, Total) " +
                        "VALUES (@Type, @RouteID, @BillDate, @Distance, @RatePerKM, @Total)", con
                    );

                    cmd.Parameters.AddWithValue("@Type", row["Type"]);
                    cmd.Parameters.AddWithValue("@RouteID", routeID);
                    cmd.Parameters.AddWithValue("@BillDate", DateTime.Parse(row["BillDate"].ToString()));
                    cmd.Parameters.AddWithValue("@Distance", decimal.Parse(row["Distance"].ToString()));
                    cmd.Parameters.AddWithValue("@RatePerKM", decimal.Parse(row["RatePerKM"].ToString()));
                    cmd.Parameters.AddWithValue("@Total", decimal.Parse(row["Total"].ToString()));

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Bills saved to database!");
                ExportToCSV();
                ClearFields();
                dtBills.Clear();
                dgvGenerateBill.DataSource = null;
                dgvGenerateBill.DataSource = dtBills;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating bills: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // ================= EXPORT TO CSV =================
        private void ExportToCSV()
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                FileName = "GeneratedBills.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        for (int i = 0; i < dgvGenerateBill.Columns.Count; i++)
                        {
                            sw.Write(dgvGenerateBill.Columns[i].HeaderText);
                            if (i < dgvGenerateBill.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        foreach (DataGridViewRow row in dgvGenerateBill.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dgvGenerateBill.Columns.Count; i++)
                                {
                                    string value = row.Cells[i].Value?.ToString().Replace(",", " ") ?? "";
                                    sw.Write(value);
                                    if (i < dgvGenerateBill.Columns.Count - 1)
                                        sw.Write(",");
                                }
                                sw.WriteLine();
                            }
                        }
                    }

                    MessageBox.Show("Bills exported to CSV successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting CSV: " + ex.Message);
                }
            }
        }

        // ================= CLEAR FIELDS =================
        private void ClearFields()
        {
            txtDistance.Clear();
            txtRate.Clear();
            txtTotal.Clear();
            BillDate.Value = DateTime.Now;

            if (cmbVehicleType.Items.Count > 0)
                cmbVehicleType.SelectedIndex = 0;

            if (cmbRoute.Items.Count > 0)
                cmbRoute.SelectedIndex = 0;
        }

        // ================= CLEAR BUTTON =================
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            dtBills.Clear();
            dgvGenerateBill.DataSource = null;
            dgvGenerateBill.DataSource = dtBills;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void btnViewRecord_Click(object sender, EventArgs e)
        {
            View_Records viewRecordsForm = new View_Records();
            viewRecordsForm.Show();
            this.Hide();
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            Generate_Bills generateBillsForm = new Generate_Bills();
            generateBillsForm.Show();
            this.Hide();
        }

        private void btnAssignDriver_Click(object sender, EventArgs e)
        {
            Assign_Drivers assignDriverForm = new Assign_Drivers();
            assignDriverForm.Show();
            this.Hide();

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            Assign_Vehicles assignVehicleForm = new Assign_Vehicles();
            assignVehicleForm.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
