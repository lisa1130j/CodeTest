namespace EmployeeApi.UnitTests
{
    public class AddEmployeeCommandStub : Employee.Application.Commands.IAddEmployeeCommand
    {
        private readonly int _stubResult;
        public AddEmployeeCommandStub(int stubResult)
        {
            _stubResult = stubResult;
        }
        public int Execute(Employee.Application.DTO.EmployeeDTO employee)
        {
            return _stubResult;
        }
    }
}
