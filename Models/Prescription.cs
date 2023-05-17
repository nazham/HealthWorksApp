using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthWorksApp.Models
{
    internal class Prescription
    {
        public int Id { get; set; }
        public PatientModel Patient { get; set; }

        public DoctorModel ReferredBy { get; set; }

        public AppointmentModel Appointment { get; set; }

        public string DiagnosisDetails { get; set; }

        public DateTime IssuedDate { get; set; }


    }
}
