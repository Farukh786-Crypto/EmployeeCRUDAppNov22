using CRUDAppServer.DAL;
using CRUDAppServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmpDbContext empDbContext;

        public EmployeesController(EmpDbContext empDbContext)
        {
            this.empDbContext = empDbContext;
        }
        [HttpGet("GetEmpList")]
        public IActionResult GetEmpList()
        {
            var listEmp = empDbContext.Employees.ToList();
            return Ok(listEmp);
        }

        [HttpGet("GetEmpId/{id}")]
        public IActionResult GetEmpId(int id)
        {
            var empData = empDbContext.Employees.Find(id);
            return Ok(empData);
        }

        [HttpPost]
        public IActionResult PostEmployee(Employee employee)
        {
            empDbContext.Employees.Add(employee);
            empDbContext.SaveChanges();
            return Ok(employee);
        }

        [HttpPut]
        public IActionResult PutEmployee(Employee employee)
        {
            var empData = empDbContext.Employees.Where(a => a.empId == employee.empId).FirstOrDefault();
            empData.empName = employee.empName;
            empData.empEmail = employee.empEmail;
            empData.empPassword = employee.empPassword;
            empDbContext.SaveChanges();
            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var empData = empDbContext.Employees.Where<Employee>(a => a.empId == id).FirstOrDefault();
            empDbContext.Employees.Remove(empData);
            empDbContext.SaveChanges();
            return Ok(empData);
        }

    }
}
