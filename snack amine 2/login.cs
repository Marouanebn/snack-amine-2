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
using System.Drawing;

namespace snack_amine_2
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=restauration;Integrated Security=True");

        public login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqa = new SqlDataAdapter("Select count(*) from login where username='" + txtiduser.Text + "' and password = '" + txtpassword.Text + "'", con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            if (dt.Rows.Count > 0 && dt.Rows[0][0].ToString() == "1")
            {
                
                this.Hide();
                laoding lod = new laoding();
                lod.Show();
            }
            else
            {
                MessageBox.Show("username or password is incorect");
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            newacc nwac = new newacc();
            nwac.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtiduser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtiduser_click(object sender, EventArgs e)
        {
            txtiduser.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            txtpassword.BackColor = SystemColors.Control;
        }

        private void txtpasssword_click(object sender, EventArgs e)
        {
            txtpassword.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel2.BackColor = SystemColors.Control;
            txtiduser.BackColor = SystemColors.Control;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
        }
    }
}
