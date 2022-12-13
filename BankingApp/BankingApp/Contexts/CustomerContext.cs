using BankingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BankingApp.Contexts
{
    public class CustomerContext:DbContext
    {

        public CustomerContext(DbContextOptions<CustomerContext> dbContext):base(dbContext)
        {

        }

        DbSet<Customer> Customers { get; set; }
    }
}
