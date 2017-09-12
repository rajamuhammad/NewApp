using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jamesthew.com.Models
{
    public class Contest
    {
        public int Contest_Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Start_Date { get; set; }
        public String End_Date { get; set; }
        public Award Award { get; set; }
        public Entries[] Entires { get; set; }
    }
}