using System.ComponentModel.DataAnnotations.Schema;

namespace MedFlow.Web.Models;

public class Turn: BaseEntity
{
    public int Number { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;

    public string Status { get; set; } = "Pending";
    
    // Relaciones
    [ForeignKey("Affiliate")]
    public Guid? AffiliateId { get; set; }
    public Affiliate? Affiliate { get; set; }

    [ForeignKey("CashDesk")]
    public Guid? CashDeskId { get; set; }
    public CashDesk? CashDesk { get; set; }
}