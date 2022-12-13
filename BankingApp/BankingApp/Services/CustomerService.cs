using BankingApp.Contexts;
using BankingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BankingApp.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly CustomerContext _db;

        public CustomerService(CustomerContext customerDbContext)
        {
            _db = customerDbContext;
        }
        public async Task<Customer> AddCustomer(Customer Customer)
        {
            var result = await this._db.Customers.AddAsync(Customer);

            await this._db.SaveChangesAsync();

            return result.Entity;

        }

        public async Task<bool> DeleteCustomer(int AccountNo)
        {
            var result = await this._db.Customers.FirstOrDefaultAsync(c => c.AccountNo
          == AccountNo);
            if (result != null)
            {
                this._db.Customers.Remove(result);
                await this._db.SaveChangesAsync();
            }
            result = await this._db.Customers.FirstOrDefaultAsync(c => c.AccountNo
              == AccountNo);
            if (result == null)
                return true;
            else
                return false;
        }

        public async Task<Customer> GetCustomerById(int AccountNo)
        {
            var result = await this._db.Customers.FirstOrDefaultAsync(c => c.AccountNo
         == AccountNo);
            if (result != null)
                return result;
            else
                return null;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await this._db.Customers.ToListAsync();
        }

        public async Task<Customer> UpdateCustomer(Customer Customer)
        {
            var result = await this._db.Customers.FirstOrDefaultAsync(c => c.AccountNo
            == Customer.AccountNo);

            if (result != null)
            {
                result.Email = Customer.Email;
                await this._db.SaveChangesAsync();
                return result;
            }
            else
                return null;
        }
    }
}
