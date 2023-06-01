using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HealthWorksApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

     

        private void Register_Load(object sender, EventArgs e)
        {
            EFHelper.SetPlaceholder(txtName, "Enter your Name");
            EFHelper.SetPlaceholder(txtUserName, "Enter your username");
            EFHelper.SetPlaceholder(txtPassword, "Enter your password");
            EFHelper.SetPlaceholder(txtAdminUserName, "Enter Admin Username");
            EFHelper.SetPlaceholder(txtAdminPass, "Enter Admin Password");




        }
    }
}
