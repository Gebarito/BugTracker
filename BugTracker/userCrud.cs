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
    public partial class userCrud : MetroSetForm
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter dataAdapter;
        //MySqlDataReader dataReader;

        string cmdSQL = "";

        public userCrud()
        {
            InitializeComponent();
        }

        private void userCrud_Load(object sender, EventArgs e)
        {
            this.txtUsername.Text = "Username";

            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Text = "Password";

            this.btnDelete.Enabled = checkAdministrator();

            refreshDataView();
        }

        private bool checkAdministrator()
        {
            string prefix = "";
            string fullUser = formLogin.s_userInSession.ToUpper();

            for (int i = 0; i < 3; i++)
                prefix += fullUser[i];

            if (prefix == "ADM")
                return true;

            return false;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "Username")
                this.txtUsername.Text = "";
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (this.txtUsername.TextLength == 0)
                this.txtUsername.Text = "Username";
        }


        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "Password")
                this.txtPassword.Text = "";
        }


        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtPassword.TextLength == 0)
                this.txtPassword.Text = "Password";
        }

        //Connection with the mysql database
        private void btnInclude_Click(object sender, EventArgs e)
        {
            bool sqlError = false;
            
            try
            {
                connection = new MySqlConnection("Server=localhost;Database=dtbBugtracker;Uid=root;Pwd=gebara");

                cmdSQL = "INSERT INTO userInfo (username,password) VALUES (@name,@pass)";

                command = new MySqlCommand(cmdSQL, connection);
                command.Parameters.AddWithValue("@name", txtUsername.Text);
                command.Parameters.AddWithValue("@pass", txtPassword.Text);

                connection.Open();

                command.ExecuteNonQuery();
                refreshDataView();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erro! " + ex.Message);
                sqlError = true;
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
                cmdSQL = "";
            }

            if (!sqlError)
            {
                MessageBox.Show("Sucessfull!");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool sqlError = false;
            int rowsAffected = 0;
            try
            {
                connection = new MySqlConnection("Server=localhost;Database=dtbBugtracker;Uid=root;Pwd=gebara");

                cmdSQL = "Delete from userInfo WHERE username = @name";

                command = new MySqlCommand(cmdSQL, connection);
                command.Parameters.AddWithValue("@name", txtUsername.Text);

                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

                refreshDataView();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error while removing a user " + ex.Message);
                sqlError = true;
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
                cmdSQL = "";
                rowsAffected = 0;
            }

            if (!sqlError)
            {
                string ErrorMessage = "Sucessfull";
                if(rowsAffected > 1) {
                    ErrorMessage += "\n" + rowsAffected.ToString() + " was removed"; 
                }
                MessageBox.Show(ErrorMessage);
            }
        }

        //Execute the sql for refresh the Data of the data grid view
        private void refreshDataView()
        {
            try
            {
                connection = new MySqlConnection("Server=localhost;Database=dtbBugtracker;Uid=root;Pwd=gebara");

                cmdSQL = "SELECT username FROM userInfo";

                dataAdapter = new MySqlDataAdapter(cmdSQL, connection);

                DataTable dt = new DataTable();

                dataAdapter.Fill(dt);

                dgvUser.DataSource = dt;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error while refreshing the data" + e.Message);
            }
        }

    }
}