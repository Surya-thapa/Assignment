using Assignment.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data
{
    public class AssignDbContext : DbContext
    {
        public AssignDbContext(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
