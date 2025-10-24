using MedFlow.Web.Models;

namespace MedFlow.Web.Interfaces;

public interface ITurnRepository: IGenericRepository<Turn>
{
    Task<Turn?> GetCurrentTurnAsync();
    Task<IEnumerable<Turn>> GetCurrentTurnsAsync();
    Task ResetDailyTurnAsync();
}