using System;
using Xunit;
using BankingApp.Models;
using BankingApp.Validators;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BankingTest
{
    public class CustomerTest:IDisposable
    {

        private Customer Customer;
        
        //setup
        public CustomerTest()
        {
            this.Customer = new Customer();
            this.Customer.AccountNo = 38458;
            this.Customer.FullName = new FullName
            {
                FirstName = "Par",
                LastName = "Bala",
                MiddleName = ""
            };
            this.Customer.Address = new Address
            {
                City = "Chennai",
                DoorNo = "536",
                StreetName = "Rajaji St"
            };
            this.Customer.Email = "Parameswaribala@gmail.com";
            this.Customer.Password = "Test@123";
            this.Customer.ContactNo = 9952032862;
        }

        [Fact] //[Test]
        public void TestAccountNo()
        {
           
            Assert.True(this.Customer.AccountNo > 0);

        }


        [Fact]

        public void TestCustomerProperties()
        {

          IList<ValidationResult> errList = new PropertyValidator().BankValidator(this.Customer.FullName);
          Assert.Equal(2, errList.Count);
          Assert.True(errList.Where(x=>x.ErrorMessage.Contains("First Name Should be" +
              " between 4 and 50 characters")).Count()>0);
          Assert.True(errList.Where(x => x.ErrorMessage.Contains("Middle Name Should be" +
                          " between 4 and 50 characters")).Count() > 0);


        }

        //teardown

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

    }
}