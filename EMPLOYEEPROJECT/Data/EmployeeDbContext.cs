﻿using EMPLOYEEPROJECT.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMPLOYEEPROJECT.Data
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set;}
        public DbSet<Department> Departments { get; set; }

        public DbSet<EmployeeDepartmentRelation> EmployeeDepartmentRelations { get; set; }

    }
}
