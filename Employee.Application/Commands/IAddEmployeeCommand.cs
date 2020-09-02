using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Application.Commands
{
    public interface IAddEmployeeCommand
    {
        //int Execute(string lastName, string firstName, string address, Application.DTO.Employee.RoleEnum role, DTO.Employee.PayTypeEnum payType, decimal compensationRate);
        int Execute(Application.DTO.EmployeeDTO employee);
    }
}
