using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMPLOYEEPROJECT
{
    public class CommonModel
    {
        [Key]
        public Int64 Id { get; set; }

        public Int64 CreatedBy { get; set; }

        public DateTime DateTimeCreated { get; set; }

        public Int64 UpdatedBy { get; set; }

        public DateTime DateTimeUpdated { get; set; }

        public Guid LastTimeUpdated { get; set; }
    }
}

