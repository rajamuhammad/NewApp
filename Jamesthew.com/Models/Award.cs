using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamesthew.com.Models
{
    public class Award
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Contest[] Contest { get; set; }
        public Participant Participant { get; set; }
    }
}
