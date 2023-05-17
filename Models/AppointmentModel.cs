using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthWorksApp.Models
{
    internal class AppointmentModel
    {
        public int ID { get; set; }
        public PatientModel Patient { get; set; }
        public DoctorModel Doctor { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime AppointmentTime { get; set; }
        public SqlMoney AmountPaid { get; set; }

    }
}
