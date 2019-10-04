using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMPLOYEEPROJECT.Models
{
    public class EmployeeDepartmentRelation:CommonModel
    {
        public Int64 EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]

        public virtual Employee Employee { get; set; }

        public Int64 DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
    }
}
