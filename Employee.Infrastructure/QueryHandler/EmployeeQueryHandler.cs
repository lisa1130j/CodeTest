using System.Collections.Generic;

namespace Employee.Infrastructure.QueryHandler
{
    public class EmployeeQueryHandler : Employee.Application.Query.IEmployeeQuery
    {
        public IEnumerable<Application.DTO.EmployeeDTO> GetEmployees()
        {
            //Typically read from a database thru EF or SP. Simulating a result set from whichever source it came from.
            return new List<Application.DTO.EmployeeDTO>
            {

                new Application.DTO.EmployeeDTO
                {
                    EmployeeId = 1,
                    FirstName = "Michael",
                    LastName = "Scott",
                    Address = "1234 Dundler Mifflin Driveway",
                    City = "Scranton",
                    State = "PA",
                    ZipCode = "15008",
                    Role = Application.DTO.EmployeeDTO.RoleEnum.Employee,
                    PayType = Application.DTO.EmployeeDTO.PayTypeEnum.Hourly,
                    CompensationRate = (decimal)15.39,
                    MaximumExpenseAmount = 0
                },
                new Application.DTO.EmployeeDTO
                {
                    EmployeeId = 2,
                    FirstName = "Jim",
                    LastName = "Pam",
                    Address = "1500 Dundler Mifflin Driveway",
                    City = "Scranton",
                    State = "PA",
                    ZipCode = "15001",
                    Role = Application.DTO.EmployeeDTO.RoleEnum.Employee,
                    PayType = Application.DTO.EmployeeDTO.PayTypeEnum.Salary,
                    CompensationRate = (decimal)40000.00,
                    MaximumExpenseAmount = 0
                    },
                    new Application.DTO.EmployeeDTO
                    {
                    EmployeeId = 3,
                    FirstName = "Stanley",
                    LastName = "Kelly",
                    Address = "56401 Dundler Mifflin Driveway",
                    City = "Scranton",
                    State = "PA",
                    ZipCode = "15007",
                    Role = Application.DTO.EmployeeDTO.RoleEnum.Manager,
                    PayType = Application.DTO.EmployeeDTO.PayTypeEnum.Salary,
                    CompensationRate = (decimal)65000.00,
                    MaximumExpenseAmount = (decimal)1500.00
                }
            };

        }
    }
}
