using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMPLOYEEPROJECT.Models
{
    public class Employee:CommonModel
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public DateTime DateOfBirth { get; set; }

        

      
    }
}
