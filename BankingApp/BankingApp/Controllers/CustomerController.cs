using BankingApp.Models;
using BankingApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        #region Property  
        private readonly ICustomerService _customerService;
        #endregion

        #region Constructor  
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        #endregion

        [HttpGet(nameof(GetCustomerById))]
        public async Task<Customer> GetCustomerById(int AccountNo)
        {
            var result = await _customerService.GetCustomerById(AccountNo);
            return result;
        }
        [HttpGet(nameof(GetCustomerDetails))]
        public async Task<IEnumerable<Customer>> GetCustomerDetails()
        {
            var result = await _customerService.GetCustomers();
            return result;
        }

        // POST api/<VehicleController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Customer Customer)
        {
            await this._customerService.AddCustomer(Customer);
            return CreatedAtRoute("Customer",
                            new { id = Customer.AccountNo }, Customer);

        }

        // PUT api/<VehicleController>/5
        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] Customer Customer)
        {
            await this._customerService.UpdateCustomer(Customer);
            return CreatedAtRoute("Customer",
                            new { id = Customer.AccountNo }, Customer);
        }

        // DELETE api/<VehicleController>/5
        [HttpDelete("{AccountNo}")]
        public async Task<IActionResult> Delete(int AccountNo)
        {

            if (await this._customerService.DeleteCustomer(AccountNo))
                return new OkResult();
            else
                return new BadRequestResult();

        }
    }
}
