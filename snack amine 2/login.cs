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
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=restauration;Integrated Security=True");

        public login()
        {
            InitializeComponent();
            this.AcceptButton = btnlogin;

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
                lod.Username = txtiduser.Text;


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

        private void txtiduser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
