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
    public partial class AddEditDoctor : Form
    {
        private DoctorModel editModel;
        /// <summary>
        /// This constructor is used for Add Doctor 
        /// </summary>
        public AddEditDoctor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This constructor is used for edit doctor
        /// </summary>
        /// <param name="doctor">The doctor model to be edited</param>
        public AddEditDoctor(DoctorModel doctor)
        {
            InitializeComponent();
            this.editModel = doctor;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       
        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            DoctorModel model = new DoctorModel()
            {
                Name = txtName.Text ,
                Qualification = txtQualification.Text,
                Gender = cmbGender.SelectedItem.ToString() ,
                Specialization = txtSpecialization.Text,
                NIC = txtNic.Text,
                MobileNO = txtMobileNo.Text


            };
            if (editModel == null) //Add Mode
            {
                int res = EFHelper.AddDoctor(model);
                if (res > 0)
                {
                    MessageBox.Show($"New Doctor was added. His Id is {res}", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error in adding a doctor", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
            else
            {
                model.ID = editModel.ID;
                int res = EFHelper.EditDoctor(model);
                if (res > 0)
                {
                    MessageBox.Show($"Doctor record was updated. ", "Update Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error in updating a doctor", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
            
            
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEditDoctor_Load(object sender, EventArgs e)
        {
            if(editModel == null) //Add Doctor mode
            {

            }
            else
            {
                txtName.Text = editModel.Name;
                txtQualification.Text = editModel.Qualification;
                cmbGender.Text = editModel.Gender;
                txtSpecialization.Text = editModel.Specialization;
                txtNic.Text = editModel.NIC;
                txtMobileNo.Text = editModel.MobileNO;

                btnAddDoctor.Text = "Update";
                this.Text = "Edit Doctor";
            }
        }

     
    }
}
