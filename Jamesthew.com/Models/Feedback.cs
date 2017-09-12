using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jamesthew.com.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public String Question { get; set; }
        public String Answer { get; set; }
        public String Comment { get; set; }
    }
}