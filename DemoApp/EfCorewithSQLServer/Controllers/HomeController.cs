using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCorewithSQLServer.Models;
using Microsoft.EntityFrameworkCore;


namespace EfCorewithSQLServer.Controllers
{
    public class HomeController : Controller
    {
        private readonly EMPLOYEECONTEXT _dbContext;
        public HomeController(EMPLOYEECONTEXT dbContext)
        {
            _dbContext = dbContext;
            
        }
      
        [HttpGet]
        public IActionResult Index()
        {

            //var _emplst = _dbContext.tblEmployees.
            //              Join(_dbContext.tblSkills, e => e.SkillID, s => s.SkillID,
            //              (e, s) => new EmployeeViewModel
            //              {
            //                  EmployeeID = e.EmployeeID,
            //                  EmployeeName = e.EmployeeName,
            //                  PhoneNumber = e.PhoneNumber,
            //                  Skill = s.Title,
            //                  YearsExperience = e.YearsExperience
            //              }).ToList();
            //IList<EmployeeViewModel> emplst = _emplst;

            //IList<tblEmployee> emplst = _dbContext.tblEmployees.FromSqlRaw<tblEmployee>("select * from tblEmployees where EmployeeID={0} and EmployeeID<>{1}",1).ToList();
            IList<EmployeeViewModel> emplst = _dbContext.AllEmployees.FromSqlRaw<EmployeeViewModel>("sp_GetAllEmployees").ToList(); 
            return View(emplst);
           
        }

      
    }
}
