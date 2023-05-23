using NASCAR_Money.Data.NascarCache;
using NASCAR_Money.Models;

namespace NASCAR_Money.Helpers
{
    public class EventIdHelper
    {
        private readonly ICacheService _cacheService;
        public EventIdHelper(ICacheService cacheService)
        {
            _cacheService = cacheService;
        }

        public async Task<int> GetUpcomingCupEventId(DateTime time)
        {
            RaceListBasic raceListBasic = await _cacheService.GetRaceListBasicAsync(time.Year);
            List<Series1> cupList = raceListBasic.series_1;
            cupList.OrderBy(r => r.date_scheduled);
            foreach (var race in cupList)
            {
                // Check if the race_time is after the given time
                if (race.date_scheduled > time)
                {
                    // This race is the next one after the given time, so return its race_id
                    return race.race_id;
                }
            }
            // No upcoming races found, return -1 or throw an exception
            return -1;
        }

        public async Task<int> GetUpcomingXfinityEventId(DateTime time)
        {
            RaceListBasic raceListBasic = await _cacheService.GetRaceListBasicAsync(time.Year);
            List<Series1> xfinityList = raceListBasic.series_1;
            xfinityList.OrderBy(r => r.date_scheduled);
            foreach (var race in xfinityList)
            {
                if (race.date_scheduled > time)
                {
                    return race.race_id;
                }
            }
            return -1;
        }

        public async Task<int> GetUpcomingTruckEventId(DateTime time)
        {
            RaceListBasic raceListBasic = await _cacheService.GetRaceListBasicAsync(time.Year);
            List<Series1> truckList = raceListBasic.series_1;
            truckList.OrderBy(r => r.date_scheduled);
            foreach (var race in truckList)
            {
                if (race.date_scheduled > time)
                {
                    return race.race_id;
                }
            }
            return -1;
        }

    }
}
