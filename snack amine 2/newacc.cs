using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snack_amine_2
{
    public partial class newacc : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=restauration;Integrated Security=True");

        public newacc()
        {
            InitializeComponent();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {

            string username = txtusername.Text.Trim();
            string password = txtpassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (con)
            {
                try
                {
                    con.Open();

                    // Check if the username already exists
                    SqlCommand checkUserCmd = new SqlCommand("SELECT COUNT(*) FROM users WHERE username=@username", con);
                    checkUserCmd.Parameters.AddWithValue("@username", username);

                    int existingUserCount = Convert.ToInt32(checkUserCmd.ExecuteScalar());

                    if (existingUserCount > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different one.");
                        return;
                    }
                    if (txtpassword.Text != txtpasswordconfirm.Text)
                    {
                        MessageBox.Show("password do not match");

                    }
                    // Register the new user
                    SqlCommand registerUserCmd = new SqlCommand("INSERT INTO users (username, password) VALUES (@username, @password)", con);
                    registerUserCmd.Parameters.AddWithValue("@username", username);
                    registerUserCmd.Parameters.AddWithValue("@password", password);

                    int rowsAffected = registerUserCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful!");
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
