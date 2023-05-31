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
    public partial class ViewDoctors : Form
    {
        public ViewDoctors()
        {
            InitializeComponent();
        }
        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            AddEditDoctor aDoctors = new AddEditDoctor();
            aDoctors.ShowDialog();

            lstDoctors.Items.Clear();
            LoadDoctors();
        }


        private void ViewDoctors_Load(object sender, EventArgs e)
        {
            
            LoadDoctors();

        }

        private void LoadDoctors()
        {
            var doctorList = EFHelper.GetDoctors();

            foreach (var doctor in doctorList)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = doctor.ID;
                item.Text = doctor.Name;
                item.SubItems.Add(doctor.Qualification);
                item.SubItems.Add(doctor.Specialization);
                item.SubItems.Add(doctor.Gender);
                item.SubItems.Add(doctor.MobileNO);

                lstDoctors.Items.Add(item);

            }
        }

        private void lstDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDltDoctor_Click(object sender, EventArgs e)
        {   if (lstDoctors.SelectedItems.Count > 0)
            {
                var selectedItem = lstDoctors.SelectedItems[0];
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
            }
            else
            {
                MessageBox.Show("You Did not select a Doctor to Delete", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            lstDoctors.Items.Clear();
            LoadDoctors();

        }

        private void btnEditDoc_Click(object sender, EventArgs e)
        {
            if (lstDoctors.SelectedItems.Count > 0)
            {
                var selectedItem = lstDoctors.SelectedItems[0];
                int doctorId = (int)selectedItem.Tag;
                DoctorModel doctor = EFHelper.GetDoctors().Where(doc => doc.ID == doctorId).FirstOrDefault();

                AddEditDoctor editForm = new AddEditDoctor(doctor);
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Did not select a Doctor to Edit", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            lstDoctors.Items.Clear();
            LoadDoctors();


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string keyword = txtse
        }

       // private void textSearch_TextChanged(object sender, EventArgs e);
        //{
        //    TextBox searchTB = (TextBox)sender;
        //    if (searchTB.Text.Length > 0)
        //    {
        //        string searchText = searchTB.Text.ToLower();
        //        var filterRecords = appList.Where(app =>
        //                                          app.DoctorName.ToLower().Contains(searchText) ||
        //                                          app.PatientName.ToLower().Contains(searchText)
        //                                          );

        //        lstAppointments.Items.Clear();
        //        PrepareAppointmentList(filterRecords.ToList());
        //    }

        //    else
        //    {
        //        lstAppointments.Items.Clear();
        //        LoadAppointments();
        //    }
        //}
    }
    }

