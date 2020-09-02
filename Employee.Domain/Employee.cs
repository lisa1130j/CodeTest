namespace Employee.Domain
{
    public class Employee
    {
        public enum PayTypeEnum
        {
            Hourly = 1,
            Salary = 2
        }

        public enum RoleEnum
        {
            Employee = 1,
            Supervisor,
            Manager
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public PayTypeEnum PayType { get; set; }
        public RoleEnum Role { get; set; }
    }
}
