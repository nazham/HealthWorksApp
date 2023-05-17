using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthWorksApp.Models
{
    public class DoctorModel : PersonModel
    {

        public string Qualification { get; set; }
        public string Gender { get; set; }
        public string Specialization { get; set; }
        public string NIC { get; set; }
        public string MobileNO { get; set; }
    }
}
