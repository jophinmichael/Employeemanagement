using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Contracts;
using EmployeeManagement.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployee _employeeRepo;

        public EmployeeController(IEmployee employeeRepo)
        {
            _employeeRepo = employeeRepo; 
        }

        [HttpGet("")]
        public IEnumerable<Employee> GetEmployees() => _employeeRepo.Get();

        [HttpGet("{Id}")]
        public Employee GetEmployeeById(int Id) => _employeeRepo.FindById(Id);

        [HttpPost("")]
        [AllowAnonymous]
        public void AddEmployee([FromBody] Employee employee) => _employeeRepo.Create(employee);
    }
}
