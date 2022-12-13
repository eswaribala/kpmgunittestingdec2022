using System.Runtime.Serialization;

namespace BankingApp.Exceptions
{
    [Serializable]
    public class InsufficientBalanceException : ApplicationException
    {
        public InsufficientBalanceException()
        {
        }

        public InsufficientBalanceException(string? message) : base(message)
        {
        }

        public InsufficientBalanceException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InsufficientBalanceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}