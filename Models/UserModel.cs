using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthWorksApp.Models
{
    internal class UserModel : PersonModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
