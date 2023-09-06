namespace Assignment.Models.Domain
{
    public class Company
    {
        public Company() 
        {
            Department = new List<Department>();
        }
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set;} 
        public string CompanyEmail { get; set;}
        public string CompanyDescription { get; set; }
        public ICollection<Department> Department { get; set;}
    }
}
