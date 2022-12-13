using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingApp.Models
{
    [Table("Customer")]
    public class Customer:IDisposable
    {
        [Key]
        [Required]
        [Column("Account_No")]
        public long AccountNo { get; set; }
        public FullName? FullName { get; set; }
        [Column("Contact_No")]
        public long ContactNo { get; set; }
        [Required,RegularExpression("^[a-zA-Z0-9.!#$%&amp;'^_`{}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*$",ErrorMessage ="Pattern Not Valid")]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "Email Should be between 10 and 150 characters")]
        [Column("Email")]
        public string? Email { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Password Should be between 4 and 10 characters")]
        [Column("Password")]
        public string? Password { get; set; }

        public void Dispose()
        {
            
        }
    }
}
