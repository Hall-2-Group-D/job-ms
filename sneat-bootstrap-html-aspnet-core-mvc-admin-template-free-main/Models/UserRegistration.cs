using System;
using System.ComponentModel.DataAnnotations;

namespace AspnetCoreMvcFull.Models
{
  public class UserRegistration
  {
    [Key]
    public int UserId { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public string Role { get; set; }

  }

}
