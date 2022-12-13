using System.ComponentModel.DataAnnotations;

namespace BankingApp.Models
{
    public class Customer:IDisposable
    {

        [Required]
        public long AccountNo { get; set; }
        public FullName? FullName { get; set; }
        public Address? Address { get; set; }
        [Required]
        public long ContactNo { get; set; }
        [Required,RegularExpression("^[a-zA-Z0-9.!#$%&amp;'^_`{}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*$",ErrorMessage ="Pattern Not Valid")]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "Email Should be between 10 and 150 characters")]
        public string? Email { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Password Should be between 4 and 10 characters")]
        public string? Password { get; set; }

        public void Dispose()
        {
            
        }
    }
}
