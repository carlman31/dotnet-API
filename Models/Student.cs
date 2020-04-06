using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarlosCuellarApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Career { get; set; }
    }
}
