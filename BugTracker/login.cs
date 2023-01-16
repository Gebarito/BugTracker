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
using System.Threading;
using MetroSet_UI.Forms;

namespace BugTracker
{
    public partial class formLogin : MetroSetForm
    {
        public formLogin()
        {
            InitializeComponent();
            this.lblErro.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtPassword.PasswordChar = '*';
        }


        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(this.txtUser.Text == "User")
                this.txtUser.Text = "";
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(this.txtUser.TextLength == 0)
                this.txtUser.Text = "User";
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


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string src_data = @"datasource=localhost;username=root;password=gebara;database=dtbBugtracker";
            MySqlConnection con = new MySqlConnection(src_data);

            try
            {
                con.Open();
                string sql_com = "select username,password from userInfo WHERE username = @txtNAME AND password = @txtPASS";
                var cmd = new MySqlCommand(sql_com, con);

                cmd.Parameters.AddWithValue("@txtNAME", txtUser.Text);
                cmd.Parameters.AddWithValue("@txtPASS", txtPassword.Text);
                var ret = cmd.ExecuteScalar();
                if (ret != null)
                    sucessful_login();
                else
                    this.lblErro.Text = "Usuario invalido";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        Thread th;
        public static string s_userInSession = "";
        private void sucessful_login()
        {
            s_userInSession = txtUser.Text;
            
            th = new Thread(openMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void openMenu()
        {
            Application.Run(new formMenu());// cria o aplicativo, funciona apenas em outra thread
        }
    }
}
