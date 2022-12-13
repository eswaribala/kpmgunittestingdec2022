using System.ComponentModel.DataAnnotations;

namespace BankingApp.Models
{
    public class Account
    {
        [Required,Range(5000,50000000,ErrorMessage ="Running Total Not in the range")]
        public long RunningTotal { get; set; }
        public DateTime OpeningDate { get; set; }   
    }
}
