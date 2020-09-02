using Employee.Application.Service;
using System.Collections.Generic;
using System.Web.Http;


namespace CodeTest.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;

        }
        public IEnumerable<Employee.Application.DTO.EmployeeDTO> Get()
        {
            return _employeeService.GetAllEmployees();
        }
    }
}
