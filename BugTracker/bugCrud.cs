using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroSet_UI.Forms;

namespace BugTracker
{
    public partial class bugCrud : MetroSetForm
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter dataAdapter;

        string cmdSQL = "";
        public bugCrud()
        {
            InitializeComponent();
        }

        private void bugCrud_Load(object sender, EventArgs e)
        {
            this.txtBugName.Text = "Bug title";
            this.txtBugText.Text = "Describe the bug!";
            this.btnRemove.Enabled = CheckAdministrator();

            RefreshDataGrid();
        }

        private bool CheckAdministrator()
        {
            string preFix = "";
            string fullUser = formLogin.s_userInSession.ToUpper();

            for (int i = 0; i < 3; i++)
                preFix += fullUser[i];

            if (preFix == "ADM")
                return true;

            return false;
        }

        //TextBox string manipulation

        //TODO:
        //Set the names and focus correctly

        private void txtBugName_Enter(object sender, EventArgs e)
        {
            if (this.txtBugName.Text == "Bug title")
                this.txtBugName.Text = "";
        }

        private void txtBugName_Leave(object sender, EventArgs e)
        {
            if (this.txtBugName.TextLength == 0)
                this.txtBugName.Text = "Bug title";
        }

        private void txtBugText_Enter(object sender, EventArgs e)
        {
            if (this.txtBugText.Text == "Describe the bug!")
                this.txtBugText.Text = "";
        }

        private void txtBugText_Leave(object sender, EventArgs e)
        {
            if (this.txtBugText.TextLength == 0)
                this.txtBugText.Text = "Describe the bug!";
        }

        //MYSQL CONNECTION
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool errorTrigger = false;
        
            try
            {
                connection = new MySqlConnection("Server=localhost;Database=dtbBugtracker;Uid=root;Pwd=gebara");
                
                cmdSQL = "INSERT INTO bugsReport(bugName,bugDesc,bugUrgency) VALUES (@name,@desc,@urgency)";

                command = new MySqlCommand(cmdSQL, connection);
                command.Parameters.AddWithValue("@name", txtBugName.Text);
                command.Parameters.AddWithValue("@desc", txtBugText.Text);
                command.Parameters.AddWithValue("@urgency", cmbPriority.SelectedItem);

                connection.Open();

                command.ExecuteNonQuery();

                RefreshDataGrid();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error! the bug report was not created " + ex.Message);
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
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            removeFormBugs remForm = new removeFormBugs();
            remForm.Show();
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

                dgvBugSQL.DataSource = dt;
            
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error while refreshing the data " + e.Message);
            }
        }

        private void dgvBugSQL_DoubleClick(object sender, EventArgs e)
        {
            this.txtBugName.Text = dgvBugSQL.SelectedCells.ToString();
        }
    }
}
