using NASCAR_Money.DbModels;
using NASCAR_Money.Models;

namespace NASCAR_Money.Services
{
    public class DriverService : IDriverService
    {
        private readonly NascarMoneyDbContext _context;

        public DriverService(NascarMoneyDbContext context)
        {
            _context = context;
        }

        public async Task<List<DriverResult>> DriverPage(int driverId)
        {
            return _context.DriverResults
                .Where(dr => dr.DriverId == driverId)
               .ToList();
        }

        public async Task<List<DriverAverageStats>> GetDriverAverageStats(
        List<int> raceSeasons = null,
        int? seriesId = null,
        List<string> trackNames = null)
        {
            IQueryable<DriverResult> query = _context.DriverResults;

            if (raceSeasons != null && raceSeasons.Any())
                query = query.Where(x => raceSeasons.Contains(x.RaceSeason.Value));

            //if (!string.IsNullOrEmpty(driverFullName))
            //    query = query.Where(x => x.DriverFullName == driverFullName);

            if (seriesId.HasValue)
                query = query.Where(x => x.SeriesId == seriesId);

            if (trackNames != null && trackNames.Any())
                query = query.Where(x => trackNames.Contains(x.TrackName));

            var results = query.GroupBy(x => x.DriverFullName)
                .Select(g => new DriverAverageStats
                {
                    DriverFullName = g.Key,
                    AverageStartPosition = g.Average(x => x.StartPosition),
                    AveragePosition = g.Average(x => x.AveragePosition),
                    AverageEndPosition = g.Average(x => x.EndPosition),
                    AverageFastLaps = g.Average(x => x.FastLaps),
                    AverageRating = g.Average(x => x.Rating),
                    AverageLeadLaps = g.Average(x => x.LeadLaps),
                    AveragePasses = g.Average(x => x.Passes)
                }).ToList();

            return results;
        }
    }
}
