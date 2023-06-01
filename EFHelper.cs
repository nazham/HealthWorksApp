using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthWorksApp.Models;

namespace HealthWorksApp
{
    public static class EFHelper
    {
        static HealthWorksEntities context;

        public static HealthWorksEntities GetContext()
        {
            context = new HealthWorksEntities();
            return context;
        }
        public static int AddDoctor(DoctorModel dModel)
        {   
            int newDoctorId = 0;
            using (var context = GetContext())
            {
                Doctor doc = new Doctor()
                {
                    Name = dModel.Name,
                    Qualification = dModel.Qualification,
                    Gender = dModel.Gender,
                    Specialization = dModel.Specialization,
                    NIC = dModel.NIC,
                    MobileNo = dModel.MobileNO,

                };

                context.Doctors.Add(doc);

                int res = context.SaveChanges();
                if (res > 0)
                {
                    newDoctorId = doc.ID;
                }
            };
            return newDoctorId;
        }

        public static List<DoctorModel> GetDoctors()
        {
            List<DoctorModel> doctorList = new List<DoctorModel>();

            using(var context = GetContext())
            {
                var list = context.Doctors.Select(

                    doc => new DoctorModel()
                    {
                        ID = doc.ID,
                        Name = doc.Name,
                        Qualification = doc.Qualification,
                        Gender = doc.Gender,
                        Specialization = doc.Specialization, 
                        NIC = doc.NIC,
                        MobileNO = doc.MobileNo
                    }
                    );
                doctorList.AddRange( list );


            }
            return doctorList;
        }

        internal static int EditDoctor(DoctorModel model)
        {
           int res = 0;
            using (var context = GetContext())
            {
                var doctor = context.Doctors.Where(doc => doc.ID == model.ID).FirstOrDefault();
                if (doctor != null)
                {
                    doctor.Name = model.Name;
                    doctor.NIC = model.NIC;
                    doctor.MobileNo = model.MobileNO;
                    doctor.Qualification = model.Qualification;
                    doctor.Specialization = model.Specialization;
                    doctor.Gender = model.Gender;

                    res = context.SaveChanges();

                }
            }

            return res;
        }

        internal static int DeleteDoctor(int doctorID)
        {
            int res = 0;
            using (var context = GetContext())
            {
                var doctor = context.Doctors.Where(doc => doc.ID == doctorID).FirstOrDefault();
                if (doctor != null)
                {
                    context.Doctors.Remove(doctor);

                    res = context.SaveChanges();

                }
            }

            return res;
        }

        internal static int AddPatient(PatientModel model)
        {
            int newPatId = 0;
            using (var context = GetContext())
            {
                Patient pat = new Patient()
                {
                    Name = model.Name,

                    Gender = model.Gender,
                    
                    MobileNo = model.MobileNO,

                    Age = model.Age

                };

                context.Patients.Add(pat);

                int res = context.SaveChanges();
                if (res > 0)
                {
                    newPatId = pat.ID;
                }
            };
            return newPatId;
        }

        public static PatientModel GetPatient(string mobileNum)
        {
            PatientModel patModel = null;

        
            

            using (var context = GetContext())
            {
                var patient = context.Patients.Where(pat => pat.MobileNo == mobileNum).FirstOrDefault();
                patModel = new PatientModel();

                    patModel.ID = patient.ID;
                   patModel.Name = patient.Name; 
                    patModel.Gender = patient.Gender;
                    patModel.MobileNO = patient.MobileNo;
                    patModel.Age = (int)patient.Age;
                    
           

            }
            return patModel;
        }

        internal static int AddAppointment(AppointmentModel appModel)
        {
            int newAppId = 0;
            using (var context = GetContext())
            {
                Appointment app = new Appointment()
                {
                    PatientID = appModel.PatientID,
                    DoctorID = appModel.DoctorID,
                    AppointmentDate = appModel.AppointmentDate,
                    AppointmentTime = appModel.AppointmentTime,
                    AmountPaid = appModel.AmountPaid,

                };

                context.Appointments.Add(app);

                int res = context.SaveChanges();
                if (res > 0)
                {
                    newAppId = app.ID;
                }
            };
            return newAppId;
        }

        internal static List<AppointmentModel> GetAppointments()
        {
            var appList = new List<AppointmentModel>();

            using (var context = GetContext())
            {
                var results = from app in context.Appointments
                              join pat in context.Patients on app.PatientID equals pat.ID
                              join doc in context.Doctors on app.DoctorID equals doc.ID
                              select new AppointmentModel
                              {
                                  ID  = app.ID,
                                  DoctorID = (int)app.DoctorID,
                                  PatientID = (int)app.PatientID,
                                  DoctorName = doc.Name,
                                  PatientName = pat.Name,
                                  AppointmentDate = (DateTime)app.AppointmentDate,
                                  AppointmentTime = (DateTime)app.AppointmentTime,
                                  AmountPaid = (decimal)app.AmountPaid,
                              };
                if(results != null)
                    appList.AddRange(results);
            }
            return appList;
        }

        internal static int DeleteAppointment(int appID)
        {
            int res = 0;
            using (var context = GetContext())
            {
                var appointment = context.Appointments.Where(app => app.ID == appID).FirstOrDefault();
                if (appointment != null)
                {
                    context.Appointments.Remove(appointment);

                    res = context.SaveChanges();

                }
            }

            return res;
        }

        internal static bool CheckCredentials(string userName, string password)
        {
            bool result = false;

            using (var context = GetContext())
            {
                result = context.Users.Any(user => user.Password == password &&
                                                        user.Username == userName);
            }
            return result;
        }

        //PlaceHolder 
        /// <summary>
        /// Sets placeholder text on a control (may not work for some controls)
        /// </summary>
        /// <param name="control">The control to set the placeholder on</param>
        /// <param name="text">The text to display as the placeholder</param>
        /// <returns>The newly-created placeholder Label</returns>
        public static Label SetPlaceholder(Control control, string text)
        {
            var placeholder = new Label
            {
                Text = text,
                Font = control.Font,
                ForeColor = Color.Gray,
                BackColor = Color.Transparent,
                Cursor = Cursors.IBeam,
                Margin = Padding.Empty,

                //get rid of the left margin that all labels have
                FlatStyle = FlatStyle.System,
                AutoSize = false,

                //Leave 1px on the left so we can see the blinking cursor
                Size = new Size(control.Size.Width - 1, control.Size.Height),
                Location = new Point(control.Location.X + 1, control.Location.Y)
            };

            //when clicking on the label, pass focus to the control
            placeholder.Click += (sender, args) => { control.Focus(); };

            //disappear when the user starts typing
            control.TextChanged += (sender, args) => {
                placeholder.Visible = string.IsNullOrEmpty(control.Text);
            };

            //stay the same size/location as the control
            EventHandler updateSize = (sender, args) => {
                placeholder.Location = new Point(control.Location.X + 1, control.Location.Y);
                placeholder.Size = new Size(control.Size.Width - 1, control.Size.Height);
            };

            control.SizeChanged += updateSize;
            control.LocationChanged += updateSize;

            control.Parent.Controls.Add(placeholder);
            placeholder.BringToFront();

            return placeholder;
        }


    }

}
