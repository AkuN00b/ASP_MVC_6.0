using Microsoft.EntityFrameworkCore;
using MVCcrud6.Models.Domain;

namespace MVCcrud6.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext()
        {
        }

        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
