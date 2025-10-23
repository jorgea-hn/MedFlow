using System.ComponentModel.DataAnnotations;

namespace MedFlow.Web.Models;

public class Affiliate: BaseEntity
{
    [Required, MaxLength(100)]
    public string Name { get; set; }
    
    [Required, MaxLength(100)]
    public string Lastname { get; set; }
    
    [Required, MaxLength(20)]
    public string DocumentNumber { get; set; }
    
    [MaxLength(15)]
    public string PhoneNumber { get; set; }
    
    [MaxLength(100)]
    public string Email { get; set; }
    
    public string? PhotoPath { get; set; }
    public string? QrCodePath { get; set; }
    
    public DateTime RegisterDate { get; set; } = DateTime.UtcNow;
    
    public ICollection<Turn>? Turns { get; set; }
}