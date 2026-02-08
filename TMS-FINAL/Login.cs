using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TMS_FINAL
{
    public partial class Login : Form
    {
        // SQL Server connection
        SqlConnection con = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TransportMS;Integrated Security=True"
        );

        public Login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both Username and Password");
                return;
            }

            try
            {
                string query = "SELECT Role FROM Users WHERE Username=@u AND Password=@p";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@u", username);
                sda.SelectCommand.Parameters.AddWithValue("@p", password);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string role = dt.Rows[0]["Role"].ToString();

                    this.Hide(); // hide login

                    if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        new Admin_Dashboard().ShowDialog();
                    }
                    else if (role.Equals("Staff", StringComparison.OrdinalIgnoreCase))
                    {
                        new Staff_Dashboard().ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

      
    }
}
