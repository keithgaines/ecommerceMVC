﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bulky.Models.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public int Name { get; set; }

        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public int? CompanyId { get; set; } // FK
        [ForeignKey("CompanyId")]
        [ValidateNever]
        public Company Company { get; set; } // Nav Property


    }
}