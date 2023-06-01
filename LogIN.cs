using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HealthWorksApp
{
    public partial class LogIN : Form
    {
        public LogIN()
        {
            InitializeComponent();
        }


        private void LogIN_Load(object sender, EventArgs e)
        {
            EFHelper.SetPlaceholder(txtUserName, "Enter your username");
            EFHelper.SetPlaceholder(txtPassword, "Enter your password");

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
           

            
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != null && txtPassword.Text != null)
            {
                if (EFHelper.CheckCredentials(txtUserName.Text, txtPassword.Text))
                    {
                        MainForm mainForm = new MainForm();
                        this.Hide();
                        mainForm.ShowDialog();
                        

                    }

                else
                    {
                        MessageBox.Show("Incorrect Username or Password", "Check Credentials", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }

            }
            else
            {
                MessageBox.Show("Enter your Username and Password", "Empty Credentials", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
           {
                btnLogIn_Click(null, null);

           }
        }

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
        }
    }
}
