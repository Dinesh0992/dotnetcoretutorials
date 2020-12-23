using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class EMPLOYEECONTEXT :DbContext
    {
        public EMPLOYEECONTEXT(DbContextOptions<EMPLOYEECONTEXT> options) : base(options)
        {

        }
        public DbSet<tblSkill> tblSkills { get; set; }
        public DbSet<tblEmployee> tblEmployees { get; set; }

        public DbSet<EmployeeViewModel> AllEmployees { get; set; }
    }
}
