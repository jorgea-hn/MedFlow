using MedFlow.Web.Models;

namespace MedFlow.Web.Interfaces;

public interface IAffiliateService
{
    Task<IEnumerable<Affiliate>> GetAllAsync();
    Task<Affiliate> GetByIdAsync(Guid id);
    Task<Affiliate> GetDocumentAsync(string documentNumber);
    Task CreateAsync(Affiliate affiliate);
    Task UpdateAsync(Affiliate affiliate);
    Task DeleteAsync(Guid id);
}