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

namespace BugTracker
{
    public partial class formMenu : MetroSetForm
    {

        public formMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            showNameonLabel();
        }

        private void showNameonLabel()
        {
            string username = formLogin.s_userInSession.Trim().ToLower();

            this.lblUsername.Text = CapitalizeFirstChar(username);
            this.lblUsername.ForeColor = System.Drawing.Color.Blue;
        }

        public string CapitalizeFirstChar(string str)
        {
            if (str == null || str == "")
            {
                throw new ArgumentException("string in wrong format (null or empty)");
            }
            else
            {
                return str[0].ToString().ToUpper() + str.Substring(1);
            }
        }


        //instantiate bug crud
        private void lblBugReport_Click(object sender, EventArgs e)
        {
            OpenBugForm();
        }
        
        private void imgBug_Click(object sender, EventArgs e)
        {
            OpenBugForm();
        }

        public void OpenBugForm()
        {
            bugCrud crudform = new bugCrud();
            crudform.Show();
        }


        //instantiate bug report
        private void lblUserReport_Click(object sender, EventArgs e)
        {
            OpenUserForm();
        }

        private void imgUser_Click(object sender, EventArgs e)
        {
            OpenUserForm();
        }

        private void OpenUserForm()
        {
            userCrud userForm = new userCrud();
            userForm.Show();
        }
    }
}
