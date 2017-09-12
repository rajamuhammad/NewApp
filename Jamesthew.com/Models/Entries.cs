using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamesthew.com.Models
{
   public class Entries
    {
        public int Entry_Id { get; set; }
        public String Recipe_Name { get; set; }
        public String Recipe_ingredients { get; set; }
        public String Recipe_Method { get; set; }
        public Participant Id{ get; set; }
        public Contest Contest_Id { get; set; }
        public int Rating { get; set; }
   }
}
