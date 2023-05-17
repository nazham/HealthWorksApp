using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthWorksApp.Models
{
    internal class PatientModel : PersonModel
    {
        public int Age { get; set; }
        public char Gender { get; set; }
        public string MobileNO { get; set; }
    }
}
