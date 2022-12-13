using BankingApp.Exceptions;
using BankingApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingMSTest
{
    [TestClass]
    public class DepositTest
    {
        private Transaction Transaction;

        public DepositTest()
        {
            Transaction = new Transaction
            {
                TransactionId=35676,
                Balance=576873,
                DOT=DateTime.Now,
                AccountNo=4565
            };
            
        }

        [TestMethod]
        public void TestMoneyDeposit()
        {
            var InitialBalance=Transaction.Balance;
            var Amount = 36485;
            Transaction.AddMoney(InitialBalance,Amount);
            Assert.AreEqual(InitialBalance + Amount, Transaction.Balance);


        }


        [TestMethod]
        public void TestMoneyWithDraw()
        {
            var InitialBalance = Transaction.Balance;
            var Amount = 4500;
            Transaction.WithdrawMoney(InitialBalance,Amount);
            Assert.AreEqual(InitialBalance - Amount, Transaction.Balance);


        }


        [TestMethod]
        public void TestMoneyWithDrawInsufficientBalance()
        {
            var InitialBalance = Transaction.Balance;
            var Amount = 5768737;
            var caughtException=Assert.ThrowsException<InsufficientBalanceException>(() 
                => Transaction.WithdrawMoney(InitialBalance,Amount));    

           Assert.AreEqual("Balance insufficient",caughtException.Message);


        }
    }

    
}
