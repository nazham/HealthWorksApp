using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
