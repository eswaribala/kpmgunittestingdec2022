using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Models;
using System.ComponentModel.DataAnnotations;
using BankingApp.Validators;


namespace BankingMSTest
{
    [TestClass]
    public class AccountTest
    {
        [DataTestMethod] //Theory
      
        [DynamicData(nameof(GenerateData), DynamicDataSourceType.Method)] //MemberData
        [DataRow(348, "2002,12,27")]
        [DataRow(348586, "2018,10,1")]
        public void TestAccountProperties(long PRunningTotal, string DOP)
        {
            var Account = new Account
            {
                RunningTotal = PRunningTotal,
                OpeningDate = DateTime.Parse(DOP)
            };
            IList<ValidationResult> errList = new PropertyValidator().BankValidator(Account);

            // Assert.Equal(1, errList.Count);
            Assert.IsTrue(errList.Where(x => x.ErrorMessage.Contains("Running Total Not in the range")).Count() > 0);

            // Assert.Equal("Running Total Not in the range", errList[0].ErrorMessage);

        }

        private static IEnumerable<Object[]> GenerateData()
        {
            yield return new Object[] { new Random().Next(50000000), new Random().Next(1970, 2022) + ",12,1" };
            yield return new Object[] { new Random().Next(50000000), new Random().Next(1970, 2022) + ",12,1" };
        }
    }
}
