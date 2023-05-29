using HealthWorksApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthWorksApp
{
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int patientId = 0;
            //Add patient details
            PatientModel model = new PatientModel()
            {
                Name = txtPatientName.Text,
                MobileNO = txtMobileNo.Text,
                Gender = (string)CBGender.SelectedItem,
                Age = int.Parse(txtAge.Text)


            };

            patientId = EFHelper.AddPatient(model);

            if (patientId > 0) //If patient record is successful or existing
            {
                //Add appointment
                AppointmentModel appModel = new AppointmentModel()
                {
                    PatientID = patientId,
                    DoctorID = (int)CBSelectDoc.SelectedValue,
                    AppointmentDate = DTAppointmentDate.Value,
                    AppointmentTime = DTAppointmentTime.Value,
                    AmountPaid = decimal.Parse(txtAmount.Text)
                };

                int res = EFHelper.AddAppointment(appModel);
                if (res > 0)
                {
                    MessageBox.Show($"Appointment for {txtPatientName.Text} was created successfully!",
                        "Appointment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error in appointment creation", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                }
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            var doctorList = EFHelper.GetDoctors();
            CBSelectDoc.DataSource = doctorList;
            CBSelectDoc.DisplayMember = "Name";
            CBSelectDoc.ValueMember = "ID";
        }

        private void DTAppointmentDate_FormatChanged(object sender, EventArgs e)
        {

        }

        private void DTAppointmentTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMobileNo_TextChanged(object sender, EventArgs e)
        {
            TextBox typedTextBox = (TextBox)sender;
            int length = typedTextBox.Text.Length;
            if (length > 0)
            {
                btnFind.Enabled = true;

            }
            else
                btnFind.Enabled = false;

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            PatientModel patient = EFHelper.GetPatient(txtMobileNo.Text);
            if (patient != null)
            {
                txtPatientName.Text = patient.Name;
                txtAge.Text = patient.Age.ToString();
                CBGender.Text = patient.Gender.ToString(); 
            }
            else
            {
                MessageBox.Show("Patient not found", "Not Found", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
