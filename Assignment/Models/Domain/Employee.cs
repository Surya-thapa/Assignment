namespace Assignment.Models.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
