using NASCAR_Money.Models;

namespace NASCAR_Money.Data.NascarCache
{
    public interface ICacheService
    {
        Task<LiveFeed> GetLiveFeedAsync();
        Task<LiveOps> GetLiveOpsAsync();
        Task<LapAverages> GetLapAveragesAsync(int year, int seriesId, int eventId);
        Task<WeekendFeed> GetWeekendFeedAsync(int year, int seriesId, int eventId);
        Task<RaceListBasic> GetRaceListBasicAsync(int year);
        Task<ScheduleCombinedFeed> GetScheduleCombinedFeedAsync(int year, int seriesId);
        Task<Drivers> GetDriversAsync();

    }
}
