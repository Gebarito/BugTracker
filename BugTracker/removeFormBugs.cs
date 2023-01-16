using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using MySql.Data.MySqlClient;

namespace BugTracker
{
    public partial class removeFormBugs : MetroSetForm
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter dataAdapter;
        string cmdSQL = "";

        public removeFormBugs()
        {
            InitializeComponent();
            RefreshDataGrid();
        }

        private void removeFormBugs_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool errorTrigger = false;
            try
            {
                connection = new MySqlConnection("Server=localhost;Database=dtbBugtracker;Uid=root;Pwd=gebara");

                cmdSQL = "DELETE from bugsReport WHERE idBug = @id";
                command = new MySqlCommand(cmdSQL, connection);
                command.Parameters.AddWithValue("@id", txtID.Text);
                connection.Open();

                command.ExecuteNonQuery();

                RefreshDataGrid();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error! the bug report was not removed " + ex.Message);
                errorTrigger = true;
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
                cmdSQL = "";
            }

            if (!errorTrigger)
            {
                MessageBox.Show("Sucessful!");
                txtID.Clear();
                txtID.Focus();
            }
        }

        private void RefreshDataGrid()
        {
            try
            {
                connection = new MySqlConnection("Server=localhost;Database=dtbBugtracker;Uid=root;Pwd=gebara");

                cmdSQL = "SELECT * from bugsReport";

                dataAdapter = new MySqlDataAdapter(cmdSQL, connection);

                DataTable dt = new DataTable();

                dataAdapter.Fill(dt);

                dataGridView1.DataSource = dt;

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error while refreshing the data " + e.Message);
            }
        }
    }
}
