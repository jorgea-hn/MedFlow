using System.ComponentModel.DataAnnotations;

namespace MedFlow.Web.Models;

public class Employee: BaseEntity
{
    [Required, MaxLength(100)]
    public string Name { get; set; }
    
    [Required, MaxLength(20)]
    public string Username { get; set; }
    
    [Required, MaxLength(100)]
    public string Password { get; set; }
    
    [MaxLength(50)]
    public string Role { get; set; }
}