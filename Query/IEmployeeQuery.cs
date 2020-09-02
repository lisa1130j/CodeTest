using System.Collections.Generic;

namespace Employee.Application.Query
{
    public interface IEmployeeQuery
    {
        IEnumerable<DTO.Employee> GetEmployees();
    }
}
