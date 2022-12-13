﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingApp.Models
{
    [Owned]
    public class FullName
    {
        [Required,RegularExpression("[A-Za-z]+",ErrorMessage ="Pattern Not Matching")]
        [StringLength(50,MinimumLength =4,ErrorMessage ="First Name Should be between 4 and 50 characters")]
        [Column("First_Name")]
        public string? FirstName { get; set; }
        [Required, RegularExpression("[A-Za-z]+", ErrorMessage = "Pattern Not Matching")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Last Name Should be between 4 and 50 characters")]
        [Column("Last_Name")]
        public string? LastName { get; set; }
        [RegularExpression("[A-Za-z]+", ErrorMessage = "Pattern Not Matching")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Middle Name Should be between 4 and 50 characters")]
        [Column("Middle_Name")]
        public string? MiddleName { get; set; }
    }
}
