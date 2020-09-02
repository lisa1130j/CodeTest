using System.Collections.Generic;

namespace Employee.Application.Service
{
    public interface IEmployeeService
    {
        IEnumerable<Application.DTO.Employee> GetAllEmployees();
        int AddEmployee(Application.DTO.Employee employee);
    }
}
