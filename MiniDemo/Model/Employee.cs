namespace MiniDemo.Model
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Sitizenship { get; set; }
    }

    public class EmployeeCollection
    {
        public List<Employee> Employees { get; set; }

        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                 new Employee()
                {
                    EmployeeId = "1",
                    Name = "Faizul",
                    Sitizenship = "Bangladesh"
                },
                new Employee()
                {
                    EmployeeId = "2",
                    Name = "Tareque",
                    Sitizenship = "Bangladesh"
                },
                new Employee()
                {
                    EmployeeId = "3",
                    Name = "Joy",
                    Sitizenship = "India"
                },
                new Employee()
                {
                    EmployeeId = "4",
                    Name = "Feroz",
                    Sitizenship = "USA"
                }
            };
        }
    }
}
