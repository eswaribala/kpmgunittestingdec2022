using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingTest.DataGenerators
{
    //custom collection
    public class AccountDataGenerator : IEnumerable<Object[]>
    {
        private readonly List<Object[]> _data= new List<Object[]>()
        {
             new Object[] { new Random().Next(50000000), new Random().Next(1970,2022)+",9,4" },
             new Object[] { new Random().Next(50000000), new Random().Next(1970,2022) + ",9,12" }

       };

    public IEnumerator<object[]> GetEnumerator()=>_data.GetEnumerator();
        

        IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        
    }
}
