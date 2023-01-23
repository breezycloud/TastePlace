using TastePlace.Shared.Models;

namespace TastePlace.Client.Interfaces
{
    public interface IDashboardService
    {
        Task<DashboardModel> GetDashboard();
    }
}
