using BankingApp.Models;
using BankingApp.Validators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace BankingMSTest
{
    [TestClass]
    public class CustomerTest
    {
        private Customer Customer;
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
            //this.Customer.Address = new Address
            //{
            //    City = "Chennai",
            //    DoorNo = "536",
            //    StreetName = "Rajaji St"
            //};
            this.Customer.Email = "Parameswaribala@gmail.com";
            this.Customer.Password = "Test@123";
            this.Customer.ContactNo = 9952032862;
        }

        [TestMethod] //[Fact]
        public void TestAccountNo()
        {
            Assert.IsTrue(this.Customer.AccountNo > 0);
        }

        [TestMethod]

        public void TestCustomerProperties()
        {

            IList<ValidationResult> errList = new PropertyValidator().BankValidator(this.Customer.FullName);
            Assert.AreEqual(2, errList.Count);
            Assert.IsTrue(errList.Where(x => x.ErrorMessage.Contains("First Name Should be" +
                " between 4 and 50 characters")).Count() > 0);
            Assert.IsTrue(errList.Where(x => x.ErrorMessage.Contains("Middle Name Should be" +
                            " between 4 and 50 characters")).Count() > 0);


        }


    }
}