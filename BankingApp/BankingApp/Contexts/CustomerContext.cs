using BankingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BankingApp.Contexts
{
    public class CustomerContext:DbContext
    {

        public CustomerContext(DbContextOptions<CustomerContext> dbContext):base(dbContext)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
