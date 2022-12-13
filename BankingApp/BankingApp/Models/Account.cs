using BankingApp.Exceptions;
using System.ComponentModel.DataAnnotations;

namespace BankingApp.Models
{
    public class Account
    {
        [Required,Range(5000,50000000,ErrorMessage ="Running Total Not in the range")]
        public long RunningTotal { get; set; }
        [Required]
        public DateTime OpeningDate { get; set; }   

        public void ReadDOP()
        {
            if (this.OpeningDate > DateTime.Now)
                throw new DOPException("Date of opening is above the current date");

        }

    }
}
