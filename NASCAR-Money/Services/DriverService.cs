using Microsoft.EntityFrameworkCore;
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
        List<string> trackNames = null,
        Dictionary<string, double> trackWeights = null)
        {
            IQueryable<DriverResult> query = _context.DriverResults;

            if (raceSeasons != null && raceSeasons.Any())
                query = query.Where(x => raceSeasons.Contains(x.RaceSeason.Value));

            if (seriesId.HasValue)
                query = query.Where(x => x.SeriesId == seriesId);

            if (trackNames != null && trackNames.Any())
                query = query.Where(x => trackNames.Contains(x.TrackName));

            var results = await query
                .GroupBy(x => x.DriverFullName)
                .Select(g => new
                {
                    DriverFullName = g.Key,
                    Results = g.Select(r => new
                    {
                        StartPosition = r.StartPosition,
                        AveragePosition = r.AveragePosition,
                        EndPosition = r.EndPosition,
                        FastLaps = r.FastLaps,
                        Rating = r.Rating,
                        LeadLaps = r.LeadLaps,
                        Passes = r.Passes,
                        TrackName = r.TrackName
                    }).ToList()
                })
                .ToListAsync();

            var finalResults = results
                .Select(g => new DriverAverageStats
                {
                    DriverFullName = g.DriverFullName,
                    AverageStartPosition = g.Results.Average(x => x.StartPosition / (trackWeights != null && trackWeights.ContainsKey(x.TrackName) ? trackWeights[x.TrackName] : 1)),
                    AveragePosition = g.Results.Average(x => x.AveragePosition / (trackWeights != null && trackWeights.ContainsKey(x.TrackName) ? trackWeights[x.TrackName] : 1)),
                    AverageEndPosition = g.Results.Average(x => x.EndPosition / (trackWeights != null && trackWeights.ContainsKey(x.TrackName) ? trackWeights[x.TrackName] : 1)),
                    AverageFastLaps = g.Results.Average(x => x.FastLaps * (trackWeights != null && trackWeights.ContainsKey(x.TrackName) ? trackWeights[x.TrackName] : 1)),
                    AverageRating = g.Results.Average(x => x.Rating * (trackWeights != null && trackWeights.ContainsKey(x.TrackName) ? trackWeights[x.TrackName] : 1)),
                    AverageLeadLaps = g.Results.Average(x => x.LeadLaps * (trackWeights != null && trackWeights.ContainsKey(x.TrackName) ? trackWeights[x.TrackName] : 1)),
                    AveragePasses = g.Results.Average(x => x.Passes * (trackWeights != null && trackWeights.ContainsKey(x.TrackName) ? trackWeights[x.TrackName] : 1))
                })
                .ToList();

            return finalResults;
        }


    }
}
