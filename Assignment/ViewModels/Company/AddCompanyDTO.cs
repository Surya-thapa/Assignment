namespace Assignment.ViewModels.Company
{
    public class AddCompanyDTO
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyDescription { get; set; }

    }
    public class UpdateCompanyDTO
    {
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyDescription { get; set; }
    }
}
