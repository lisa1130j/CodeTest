using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Application.DTO;

namespace EmployeeApi.UnitTests
{
    public class EmployeeQueryStub : Employee.Application.Query.IEmployeeQuery
    {
        public IEnumerable<Employee.Application.DTO.EmployeeDTO> GetEmployees()
        {
            //mock data
            return new List<Employee.Application.DTO.EmployeeDTO>
            {

                new Employee.Application.DTO.EmployeeDTO
                {
                    EmployeeId = 1,
                    FirstName = "Michael",
                    LastName = "Scott",
                    Address = "1234 Dundler Mifflin Driveway",
                    City = "Scranton",
                    State = "PA",
                    ZipCode = "15008",
                    Role = Employee.Application.DTO.EmployeeDTO.RoleEnum.Employee,
                    PayType = Employee.Application.DTO.EmployeeDTO.PayTypeEnum.Hourly,
                    CompensationRate = (decimal)15.39,
                    MaximumExpenseAmount = 0
                },
                new Employee.Application.DTO.EmployeeDTO
                {
                    EmployeeId = 2,
                    FirstName = "Jim",
                    LastName = "Pam",
                    Address = "1500 Dundler Mifflin Driveway",
                    City = "Scranton",
                    State = "PA",
                    ZipCode = "15001",
                    Role = Employee.Application.DTO.EmployeeDTO.RoleEnum.Employee,
                    PayType = Employee.Application.DTO.EmployeeDTO.PayTypeEnum.Salary,
                    CompensationRate = (decimal)40000.00,
                    MaximumExpenseAmount = 0
                    },
                    new Employee.Application.DTO.EmployeeDTO
                    {
                    EmployeeId = 3,
                    FirstName = "Stanley",
                    LastName = "Kelly",
                    Address = "56401 Dundler Mifflin Driveway",
                    City = "Scranton",
                    State = "PA",
                    ZipCode = "15007",
                    Role = Employee.Application.DTO.EmployeeDTO.RoleEnum.Manager,
                    PayType = Employee.Application.DTO.EmployeeDTO.PayTypeEnum.Salary,
                    CompensationRate = (decimal)65000.00,
                    MaximumExpenseAmount = (decimal)1500.00
                }
            };
        }
    }
}
