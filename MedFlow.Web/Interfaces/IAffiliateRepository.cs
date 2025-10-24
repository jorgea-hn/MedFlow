using MedFlow.Web.Models;

namespace MedFlow.Web.Interfaces;

public interface IAffiliateRepository: IGenericRepository<Affiliate>
{
    Task<Affiliate> GetByDocumentAsync(string documentNumber);
}