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
        List<AppointmentModel> appList;
        AppointmentModel appointmentToPrint;
        public ViewAppointments()
        {
            InitializeComponent();
            appList = new List<AppointmentModel>();
        }


        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            AddAppointment aAppointment = new AddAppointment();
            aAppointment.ShowDialog();

            lstAppointments.Items.Clear();
            LoadAppointments();

        }


        private void ViewAppointments_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            appList = EFHelper.GetAppointments();

            PrepareAppointmentList(appList);
        }

        private void PrepareAppointmentList(List<AppointmentModel> list)
        {
            foreach (var appointment in list)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = appointment.ID;
                item.Text = appointment.PatientName;
                item.SubItems.Add(appointment.DoctorName);
                item.SubItems.Add(appointment.AppointmentDate.ToShortDateString());
                item.SubItems.Add(appointment.AppointmentTime.ToShortTimeString());
                item.SubItems.Add(appointment.AmountPaid.ToString());


                lstAppointments.Items.Add(item);

            }
        }

     
        private void btnDltAppointment_Click(object sender, EventArgs e)
        {
            if (lstAppointments.SelectedItems.Count > 0)
            { 
            var selectedItem = lstAppointments.SelectedItems[0];
           
                int appId = (int)selectedItem.Tag;
                int res = EFHelper.DeleteAppointment(appId);
                if (res > 0)
                {
                    MessageBox.Show($"Appointment was successfully Deleted. It's Id is {res}", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error in deleting a Appointment", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Did not select an appointment to Delete", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        
            lstAppointments.Items.Clear();
            LoadAppointments();

        }

        private void txtSearchApp_TextChanged(object sender, EventArgs e)
        {
            TextBox searchTB = (TextBox)sender;
            if (searchTB.Text.Length > 0)
            {
                string searchText = searchTB.Text.ToLower();
                var filterRecords = appList.Where(app =>
                                                  app.DoctorName.ToLower().Contains(searchText) ||
                                                  app.PatientName.ToLower().Contains(searchText)
                                                  );

                lstAppointments.Items.Clear();
                PrepareAppointmentList(filterRecords.ToList());
            }

            else
            {
                lstAppointments.Items.Clear ();
                LoadAppointments();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lstAppointments.SelectedItems.Count > 0)
            {
                var selectedItem = lstAppointments.SelectedItems[0];

                int appId = (int)selectedItem.Tag;
                appointmentToPrint = EFHelper.GetAppointments()
                                        .Where(app => app.ID == appId)
                                        .FirstOrDefault();
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Did not select an appointment to Print", "Selection Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string doctorName = appointmentToPrint.DoctorName;

            System.Drawing.Font printFont =
                new System.Drawing.Font("Arial", 35,
                System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(doctorName, printFont,
                System.Drawing.Brushes.Red, 0, 0);

            
        }
    }
}
