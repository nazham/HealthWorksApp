using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace HealthWorksApp
{
    public partial class Dashboard : Form
    {
        public object PnlNav { get; private set; }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
             int nHeightEllipse

          );



        public Dashboard()
        {
            InitializeComponent();
         
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            FormDashboard formDashboard_Vrb = new FormDashboard()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formDashboard_Vrb);
            formDashboard_Vrb.Show();
        }


        //Dashboard
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            FormDashboard formDashboard_Vrb = new FormDashboard() 
            { Dock = DockStyle.Fill, TopLevel = false, TopMost=true};
            formDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add( formDashboard_Vrb );
            formDashboard_Vrb.Show();

        }


        //Appointments
        private void btnViewApp_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnViewApp.Height;
            pnlNav.Top = btnViewApp.Top;
            pnlNav.Left = btnViewApp.Left;
            btnViewApp.BackColor = Color.FromArgb(46, 51, 73);

            //ViewAppointments vAppoint = new ViewAppointments();
            //vAppoint.ShowDialog();

            lblTitle.Text = "Appoinments";
            this.pnlFormLoader.Controls.Clear();
            ViewAppointments vAppoint = new ViewAppointments()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            vAppoint.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(vAppoint);
            vAppoint.Show();

        }



        //Doctors
        private void btnViewDoctor_Click(object sender, EventArgs e)
        {
            //ViewDoctors vDoctors = new ViewDoctors();
            //vDoctors.ShowDialog();

            pnlNav.Height = btnViewDoctor.Height;
            pnlNav.Top = btnViewDoctor.Top;
            pnlNav.Left = btnViewDoctor.Left;
            btnViewDoctor.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Doctors";
            this.pnlFormLoader.Controls.Clear();
            ViewDoctors vDoctors = new ViewDoctors()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            vDoctors.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(vDoctors);
            vDoctors.Show();
        }


        //Clicking the patient button opens the addappointments 
        //still didn't create the viewpatients
        //Patients
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.ShowDialog();

            pnlNav.Height = btnAddPatient.Height;
            pnlNav.Top = btnAddPatient.Top;
            pnlNav.Left = btnAddPatient.Left;
            btnAddPatient.BackColor = Color.FromArgb(46, 51, 73);
        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnViewApp_Leave(object sender, EventArgs e)
        {
            btnViewApp.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnViewDoctor_Leave(object sender, EventArgs e)
        {
            btnViewDoctor.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnPatient_Leave(object sender, EventArgs e)
        {
            btnPatient.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
