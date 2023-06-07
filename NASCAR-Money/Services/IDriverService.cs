using NASCAR_Money.DbModels;
using NASCAR_Money.Models;

namespace NASCAR_Money.Services
{
    public interface IDriverService
    {
        Task<List<DriverResult>> DriverPage(int driverId);
        Task<List<DriverAverageStats>> GetDriverAverageStats(
        List<int> raceSeasons = null,
        int? seriesId = null,
        List<string> trackNames = null,
        Dictionary<string, double> trackWeights = null);
        Task<List<DriverResult>> GetLoopDataByRaceId(List<int> raceIds);
    }
}
