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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace snack_amine_2
{
    public partial class laoding : Form
    {
        public string Username { get; set; }
        public laoding()
        {
            InitializeComponent();
            pbar.Value = 0;

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            pbar.Value += 4;
            pbar.Text = pbar.Value.ToString() + "%";
            if (pbar.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                mainmenu main = new mainmenu();
                main.Show();

            }
        }

        private void laoding_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome " + Username;
        }
       

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void UpdateLabel()
        {
          
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
