using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
public class User : DbContext
{
    public int ID { get; set; }

  //  [Required(ErrorMessage = "Username is required")]
  //  [StringLength(50, ErrorMessage = "Username must be between 3 and 50 characters", MinimumLength = 3)]
    public required string Username { get; set; }

  //  [Required(ErrorMessage = "Email is required")]
  //  [EmailAddress(ErrorMessage = "Invalid email address")]
    public required string Email { get; set; }

  //  [Required(ErrorMessage = "Password is required")]
   // [StringLength(100, ErrorMessage = "Password must be at least 8 characters", MinimumLength = 8)]
    public required string Password { get; set; }

        public required string PhoneNumber { get; set; }
    public DateTime RegistrationDate { get; set; }
    
}