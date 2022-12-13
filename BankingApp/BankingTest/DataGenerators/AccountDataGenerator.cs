using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingTest.DataGenerators
{
    public class AccountDataGenerator
    {
        public static IEnumerable<Object[]> GenerateData()
        {
            yield return new Object[] { new Random().Next(50000000), new Random().Next(2022) + ",9,11" };
            yield return new Object[] { new Random().Next(50000000), new Random().Next(2022) + ",9,14" };
        }

    }
}
