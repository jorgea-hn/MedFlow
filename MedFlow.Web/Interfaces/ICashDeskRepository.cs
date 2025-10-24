using MedFlow.Web.Models;

namespace MedFlow.Web.Interfaces;

public interface ICashDeskRepository: IGenericRepository<CashDesk>
{
    Task<IEnumerable<CashDesk>> GetOpenCashDesksAsync();
    Task AssignEmployeeAsync(Guid cashDeskId, String employeeName);
}