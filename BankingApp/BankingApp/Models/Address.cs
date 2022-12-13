using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingApp.Models
{
    [Table("Address")]
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Address_Id")]
        public long AddressId { get; set; }
        [Required, RegularExpression("[A-Za-z0-9]+", ErrorMessage = "Pattern Not Matching")]
        [StringLength(5, MinimumLength = 1, ErrorMessage = "Door No Should be between 1 and 5 characters")]
        [Column("Door_No")]
        public string? DoorNo { get; set; }
        [Required, RegularExpression("[A-Za-z0-9]+", ErrorMessage = "Pattern Not Matching")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Street Name Should be between 5 and 100 characters")]
        [Column("Street_Name")]
        public string? StreetName { get; set; }
        [Required, RegularExpression("[A-Za-z]+", ErrorMessage = "Pattern Not Matching")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "City Should be between 3 and 100 characters")]
        [Column("City")]
        public string? City { get; set; }

        [ForeignKey("Customer")]
        [Column("Account_No_FK")]
        public long AccountNo { get; set; }
        public Customer? Customer { get; set; }

    }
}
