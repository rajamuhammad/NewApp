using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamesthew.com.Models
{
    public class Participant
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public Byte Subcription { get; set; }
    }
}
