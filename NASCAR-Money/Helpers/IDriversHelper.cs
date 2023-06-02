using NASCAR_Money.Models;

namespace NASCAR_Money.Helpers
{
    public interface IDriversHelper
    {
        Task<List<DriverData>> GetDriversList();
        Task<DriverData> GetDriverById(int driverId);
        Task<List<DriverData>> GetCupDriversList();
        Task<List<DriverData>> GetXfinityDriversList();
        Task<List<DriverData>> GetTruckDriversList();
        Task<List<DriverData>> GetCurrentCupDriversList();
        Task<List<DriverData>> GetCurrentXfinityDriversList();
        Task<List<DriverData>> GetCurrentTruckDriversList();
        Task<DriverData> GetDriverByMasterId(int driverId);

    }
}
