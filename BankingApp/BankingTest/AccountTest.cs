using BankingApp.Exceptions;
using BankingApp.Models;
using BankingApp.Validators;
using BankingTest.DataGenerators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTest
{
    public class AccountTest
    {
       
        [Theory]
        [ClassData(typeof(AccountDataGenerator))]
        [MemberData(nameof(GenerateData))]
        [InlineData(348, "2002,12,27")]
        [InlineData(348586, "2018,10,1")]
        public void TestAccountProperties(long PRunningTotal, string DOP)
        {
            var Account = new Account
            {
                RunningTotal = PRunningTotal,
                OpeningDate = DateTime.Parse(DOP)
            };
            IList<ValidationResult> errList =  new PropertyValidator().BankValidator(Account);

            // Assert.Equal(1, errList.Count);
             Assert.True(errList.Where(x => x.ErrorMessage.Contains("Running Total Not in the range")).Count() > 0);
          
           // Assert.Equal("Running Total Not in the range", errList[0].ErrorMessage);

        }

        [Trait("Category","Exception")]

        [Fact]
        public void TestDOP()
        {
            var Account = new Account
            {
                OpeningDate = new DateTime(2023, 1, 1),
                RunningTotal = 59695
            };

          var caughtException=  Assert.Throws<DOPException>(() =>Account.ReadDOP());
          Assert.Equal("Date of opening is above the current date",caughtException.Message);    

        }



        private static IEnumerable<Object[]> GenerateData()
        {
            yield return new Object[] { new Random().Next(50000000), new Random().Next(1970,2022)+",12,1" };
            yield return new Object[] { new Random().Next(50000000), new Random().Next(1970,2022) + ",12,1" };
        }


    }
}
