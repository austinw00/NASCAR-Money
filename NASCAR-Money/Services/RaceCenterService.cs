using Microsoft.EntityFrameworkCore;
using NASCAR_Money.Data.NascarCache;
using NASCAR_Money.DbModels;
using NASCAR_Money.Models;
using NASCAR_Money.Models.ViewModels;

namespace NASCAR_Money.Services
{
    public class RaceCenterService : IRaceCenterService
    {
        private readonly ICacheService _cacheService;
        private readonly NascarMoneyDbContext _context;

        public RaceCenterService(ICacheService cacheService, NascarMoneyDbContext context)
        {
            _cacheService = cacheService;
            _context = context;
        }
        public async Task<RaceCenterViewModel> GetRaceCenter(int year, int seriesId, int raceId)
        {
            var _scheduleCombinedFeed = await _cacheService.GetScheduleCombinedFeedAsync(year, seriesId);
            Response _raceWeekend = _scheduleCombinedFeed.response.Where(x => x.Race_Id == raceId).FirstOrDefault();
            var _weekendFeed = await _cacheService.GetWeekendFeedAsync(year, seriesId, raceId);
            //var _lapAverages = await _cacheService.GetLapAveragesAsync(year, seriesId, raceId);
            var _trackInfo = await _context.Tracks.Where(x => x.TrackId == _weekendFeed.weekend_race.FirstOrDefault().track_id).FirstOrDefaultAsync();
            var _raceListBasic = await _cacheService.GetRaceListBasicAsync(year);
            var raceCenterViewModel = new RaceCenterViewModel
            {
                scheduleCombinedFeed = _raceWeekend,
                weekendFeed = _weekendFeed,
                //lapAverages = _lapAverages,
                trackInfo = _trackInfo,
                raceListBasic = _raceListBasic
            };
            return raceCenterViewModel;
        }

        public async Task<IndexViewModel> GetIndexViewModel(int cupRaceId, int xfinityRaceId, int truckRaceId)
        {
            var _scheduleCombinedFeedCup = await _cacheService.GetScheduleCombinedFeedAsync(DateTime.Now.Year, 1);
            var _scheduleCombinedFeedXfinity = await _cacheService.GetScheduleCombinedFeedAsync(DateTime.Now.Year, 2);
            var _scheduleCombinedFeedTruck = await _cacheService.GetScheduleCombinedFeedAsync(DateTime.Now.Year, 3);


            var indexViewModel = new IndexViewModel
            {
                CupDetails = _scheduleCombinedFeedCup.response.Where(x => x.Race_Id == cupRaceId).FirstOrDefault(),
                XfinityDetails = _scheduleCombinedFeedXfinity.response.Where(x => x.Race_Id == xfinityRaceId).FirstOrDefault(),
                TruckDetails = _scheduleCombinedFeedTruck.response.Where(x => x.Race_Id == truckRaceId).FirstOrDefault()
            };

            return indexViewModel;
        }


    }
}
