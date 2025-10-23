using System.ComponentModel.DataAnnotations;

namespace MedFlow.Web.Models;

public class CashDesk: BaseEntity
{
    [Required, MaxLength(50)]
    public string Name { get; set; }
    
    public bool IsOpen { get; set; }
    
    public  string? AssignedEmployee  { get; set; }
    
    public ICollection<Turn>? Turns { get; set; }
}