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

    public partial class mainmenu : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=restauration;Integrated Security=True");

        public string Username { get; set; }
        public mainmenu()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;


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
            label7.Text = "Welcome " + Username;

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pnlreservation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=restauration;Integrated Security=True"))
                {
                    connection.Open();

                    // Retrieve values from controls
                    string nomClient = txtnp.Text;
                    string telephone = txtt.Text;
                    DateTime dateReservation = datepicker.Value;
                    int nombrePersonnes = Convert.ToInt32(txtp.Text);
                    int numeroTable = Convert.ToInt32(txtnt.Text);
                    string statut = texts.Text;
                    string notes = txtbn.Text;

                    // Create SQL query for INSERT
                    string sqlInsert = "INSERT INTO Reservation (NomClient, Telephone, DateReservation, NombrePersonnes, NumeroTable, Statut, Notes) " +
                                       "VALUES (@NomClient, @Telephone, @DateReservation, @NombrePersonnes, @NumeroTable, @Statut, @Notes)";

                    // Execute INSERT query
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        command.Parameters.AddWithValue("@NomClient", nomClient);
                        command.Parameters.AddWithValue("@Telephone", telephone);
                        command.Parameters.AddWithValue("@DateReservation", dateReservation);
                        command.Parameters.AddWithValue("@NombrePersonnes", nombrePersonnes);
                        command.Parameters.AddWithValue("@NumeroTable", numeroTable);
                        command.Parameters.AddWithValue("@Statut", statut);
                        command.Parameters.AddWithValue("@Notes", notes);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Reservation added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload the data into the DataGridView
                    LoadReservationData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datepicker_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(datepicker.Value.ToString());

        }

        private void txtt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not the header
            if (e.RowIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Initialize a StringBuilder to store the data
                StringBuilder rowData = new StringBuilder();

                // Iterate through all cells in the selected row
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    // Append the cell value to the StringBuilder
                    rowData.Append(cell.Value.ToString()).Append(" ");
                }

                // Display the data or perform any other action
                MessageBox.Show($"Selected Reservation Data:\n{rowData.ToString().Trim()}");
            }
        }
        private void LoadReservationData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=restauration;Integrated Security=True"))
                {
                    connection.Open();

                    // Create SQL query for SELECT
                    string sqlSelect = "SELECT * FROM Reservation";

                    // Create a DataTable to store the results
                    DataTable dataTable = new DataTable();

                    // Execute SELECT query
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, connection))
                    {
                        adapter.Fill(dataTable);
                    }

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {

        }
    }

}
