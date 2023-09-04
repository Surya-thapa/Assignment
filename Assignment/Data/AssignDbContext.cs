using Assignment.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data
{
    public class AssignDbContext : DbContext
    {
        public AssignDbContext(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<Company> Company { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Company>(c =>
            {
                c.HasKey(x => x.Id);

                c.Property(x => x.CompanyName)
                .HasMaxLength(100)
                .IsRequired();

                c.Property(x => x.CompanyPhone)
                .HasMaxLength(20)
                .IsRequired();
                c.Property(x => x.CompanyEmail)
                .HasMaxLength(300)
                .IsRequired();

                c.Property(x => x.CompanyDescription)
                .HasMaxLength(100)
                .IsRequired();
            });
        }

    }
}
