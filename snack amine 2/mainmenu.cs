using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
            LoadReservationData();


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
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the form/application
                this.Close();
                Application.Exit();

            }
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

        // Populate the TextBoxes with the values from the selected row
        txtnp.Text = selectedRow.Cells["NomClient"].Value.ToString();
        txtt.Text = selectedRow.Cells["Telephone"].Value.ToString();
        datepicker.Value = Convert.ToDateTime(selectedRow.Cells["DateReservation"].Value);
        txtp.Text = selectedRow.Cells["NombrePersonnes"].Value.ToString();
        txtnt.Text = selectedRow.Cells["NumeroTable"].Value.ToString();
        texts.Text = selectedRow.Cells["Statut"].Value.ToString();
        txtbn.Text = selectedRow.Cells["Notes"].Value.ToString();
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the value from the ID column of the selected row
                int reservationID = Convert.ToInt32(selectedRow.Cells["IDRESERVATION"].Value);

                // Call a method to delete the row from the database
                DeleteReservation(reservationID);

                // Remove the row from the DataGridView
                dataGridView1.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteReservation(int reservationID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=restauration;Integrated Security=True"))
                {
                    connection.Open();

                    // Create SQL query for DELETE
                    string sqlDelete = "DELETE FROM Reservation WHERE IDRESERVATION = @ReservationID";

                    // Execute DELETE query
                    using (SqlCommand command = new SqlCommand(sqlDelete, connection))
                    {
                        command.Parameters.AddWithValue("@ReservationID", reservationID);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Reservation deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the value from the ID column of the selected row
                int reservationID = Convert.ToInt32(selectedRow.Cells["IDRESERVATION"].Value);

                try
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=restauration;Integrated Security=True"))
                    {
                        connection.Open();

                        // Create SQL query for UPDATE
                        string sqlUpdate = "UPDATE Reservation SET NomClient = @NomClient, Telephone = @Telephone, " +
                                           "DateReservation = @DateReservation, NombrePersonnes = @NombrePersonnes, " +
                                           "NumeroTable = @NumeroTable, Statut = @Statut, Notes = @Notes " +
                                           "WHERE IDRESERVATION = @ReservationID";

                        // Execute UPDATE query
                        using (SqlCommand command = new SqlCommand(sqlUpdate, connection))
                        {
                            command.Parameters.AddWithValue("@NomClient", txtnp.Text);
                            command.Parameters.AddWithValue("@Telephone", txtt.Text);
                            command.Parameters.AddWithValue("@DateReservation", datepicker.Value);
                            command.Parameters.AddWithValue("@NombrePersonnes", Convert.ToInt32(txtp.Text));
                            command.Parameters.AddWithValue("@NumeroTable", Convert.ToInt32(txtnt.Text));
                            command.Parameters.AddWithValue("@Statut", texts.Text);
                            command.Parameters.AddWithValue("@Notes", txtbn.Text);
                            command.Parameters.AddWithValue("@ReservationID", reservationID);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Reservation updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reload the data into the DataGridView
                        LoadReservationData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
