using BankingApp.Models;

namespace BankingApp.Services
{
    public interface ICustomerService
    {
        //CRUD
        Task<Customer> AddCustomer(Customer Customer);
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> UpdateCustomer(Customer Customer);
        Task<Boolean> DeleteCustomer(int AccountNo);
        Task<Customer> GetCustomerById(int AccountNo);


    }
}
