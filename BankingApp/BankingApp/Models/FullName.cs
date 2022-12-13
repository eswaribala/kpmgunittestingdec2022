using System.ComponentModel.DataAnnotations;

namespace BankingApp.Models
{

    public class FullName
    {
        [Required,RegularExpression("[A-Za-z]+",ErrorMessage ="Pattern Not Matching")]
        [StringLength(50,MinimumLength =4,ErrorMessage ="First Name Should be between 4 and 50 characters")]
        public string? FirstName { get; set; }
        [Required, RegularExpression("[A-Za-z]+", ErrorMessage = "Pattern Not Matching")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Last Name Should be between 4 and 50 characters")]
        public string? LastName { get; set; }
        [RegularExpression("[A-Za-z]+", ErrorMessage = "Pattern Not Matching")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Middle Name Should be between 4 and 50 characters")]
        public string? MiddleName { get; set; }
    }
}
