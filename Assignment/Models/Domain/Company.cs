namespace Assignment.Models.Domain
{
    public class Company
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set;} 
        public string CompanyEmail { get; set;}
        public string CompanyDescription { get; set; }

    }
}
