using BulkyBook.Utility;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BulkyBook.Models;

public class ApplicationUser : IdentityUser
{
    [Required]
    public string FullName { get; set; }

    public string? StreetAddress { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }

    public bool IsDeleted { get; set; }
    public Status Status { get; set; }
    public string? ReferralCode { get; set; }

    //public int? CompanyId { get; set; }
    //[ForeignKey("CompanyId")]
    //[ValidateNever]
    //public Company? Company { get; set; }
    [NotMapped]
    public string Role { get; set; }
}
