using BankingApp.Exceptions;

namespace BankingApp.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int Balance { get; set; }
        public DateTime DOT { get; set; }
        public int AccountNo { get; set; }

        public void AddMoney(int initialbalance,int v)
        {
            this.Balance = initialbalance + v;
        }

        public void WithdrawMoney(int initialbalance,int amount)
        {
            if (initialbalance > amount)
                this.Balance = initialbalance - amount;
            else
                throw new InsufficientBalanceException("Balance insufficient");
        }
    }
}
