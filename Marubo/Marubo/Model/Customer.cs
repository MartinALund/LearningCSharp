using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marubo.Model
{
    class Customer
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int FailedAttempts { get; set; }
        public int LocationZip { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }

    }
}
