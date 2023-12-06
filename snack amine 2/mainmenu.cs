using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace snack_amine_2
{
    public partial class mainmenu : Form
    {
        public string Username { get; set; }
        public mainmenu()
        {
            InitializeComponent();
        }

        private void interface_Load(object sender, EventArgs e)
        {
            label7.Text = "Welcome " + Username;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlmenu.Visible = true;
            pnlreservation.Visible = false;
            pnlpromo.Visible = false;
            pnlstat.Visible = false;
            pnlutilisateur.Visible = false;
            pnlparametres.Visible = false;
        }

        private void btnreservation_Click(object sender, EventArgs e)
        {
            pnlreservation.Visible = true;
            pnlmenu.Visible = false;
           
            pnlpromo.Visible = false;
            pnlstat.Visible = false;
            pnlutilisateur.Visible = false;
            pnlparametres.Visible = false;
        }

        private void btnpromo_Click(object sender, EventArgs e)
        {
            pnlreservation.Visible = false;
            pnlmenu.Visible = false;

            pnlpromo.Visible = true;
            pnlstat.Visible = false;
            pnlutilisateur.Visible = false;
            pnlparametres.Visible = false;
        }

        private void btnstat_Click(object sender, EventArgs e)
        {
            pnlreservation.Visible = false;
            pnlmenu.Visible = false;

            pnlpromo.Visible = false;
            pnlstat.Visible = true;
            pnlutilisateur.Visible = false;
            pnlparametres.Visible = false;
        }

        private void btnutilisateur_Click(object sender, EventArgs e)
        {
            pnlreservation.Visible = false;
            pnlmenu.Visible = false;

            pnlpromo.Visible = false;
            pnlstat.Visible = false;
            pnlutilisateur.Visible = true;
            pnlparametres.Visible = false;
        }

        private void btnpara_Click(object sender, EventArgs e)
        {
            pnlreservation.Visible = false;
            pnlmenu.Visible = false;

            pnlpromo.Visible = false;
            pnlstat.Visible = false;
            pnlutilisateur.Visible = false;
            pnlparametres.Visible = true;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
