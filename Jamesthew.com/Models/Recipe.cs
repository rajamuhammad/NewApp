using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jamesthew.com.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Ingredients { get; set; }
        public String Method { get; set; }
        public String Type { get; set; }
    }
}