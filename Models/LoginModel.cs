using System.ComponentModel.DataAnnotations;

namespace BusShuttle.Models;

public class LoginModel
{
    [Required]
    [StringLength(60, MinimumLength = 3)]
    public string Username { get; set; }
    
    [Required]
    [StringLength(60, MinimumLength = 3)]
    public string Password { get; set; }
    
    
    
}