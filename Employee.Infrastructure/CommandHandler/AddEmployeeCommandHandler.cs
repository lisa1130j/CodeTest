namespace Employee.Infrastructure.CommandHandler
{
    public class AddEmployeeCommandHandler : Application.Commands.IAddEmployeeCommand
    {
        public int Execute(Application.DTO.EmployeeDTO employee)
        {

            //insert to db via SP / query. If using EF, i would just use the EmployeeRepository
            return employee.EmployeeId;
        }
    }
}
