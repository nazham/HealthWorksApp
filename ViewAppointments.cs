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
    public partial class ViewAppointments : Form
    {
        public ViewAppointments()
        {
            InitializeComponent();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            AddAppointment aAppointment = new AddAppointment();
            aAppointment.ShowDialog();

            lstAppointments.Items.Clear();
            LoadAppointments();
        }


        private void ViewAppointments_Load(object sender, EventArgs e)
        {

        }

        private void LoadAppointments()
        {
            var patientList = EFHelper.GetPatients();

            foreach (var patient in patientList)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = patient.ID;
                item.Text = patient.Name;
                item.SubItems.Add(patient.MobileNO);
                item.SubItems.Add(patient.Age);
                item.SubItems.Add(patient.Gender);
                

                lstAppointments.Items.Add(item);

            }
        }

        private void lstDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDltDoctor_Click(object sender, EventArgs e)
        {
            var selectedItem = lstAppointments.SelectedItems[0];
            int doctorId = (int)selectedItem.Tag;
            int res = EFHelper.DeleteDoctor(doctorId);
            if (res > 0)
            {
                MessageBox.Show($"Doctor was successfully Deleted. His Id is {res}", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error in deleting a doctor", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            lstAppointments.Items.Clear();
            LoadDoctors();

        }

        private void btnEditDoc_Click(object sender, EventArgs e)
        {
            var selectedItem = lstAppointments.SelectedItems[0];
            int doctorId = (int)selectedItem.Tag;
            DoctorModel doctor = EFHelper.GetDoctors().Where(doc => doc.ID == doctorId).FirstOrDefault();

            AddEditDoctor editForm = new AddEditDoctor(doctor);
            editForm.ShowDialog();

            lstAppointments.Items.Clear();
            LoadDoctors();

        }

       
    }
}
