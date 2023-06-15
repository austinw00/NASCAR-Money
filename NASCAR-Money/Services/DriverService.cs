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

        public async Task<List<DriverResult>> GetLoopDataByRaceId(List<int> raceIds)
        {
            // Just fetch the data, do not do the GroupBy yet
            List<DriverResult> driverResults = new List<DriverResult>();

            if (raceIds != null && raceIds.Any())
                driverResults = await _context.DriverResults.Where(x => raceIds.Contains(x.RaceId)).ToListAsync();

            // Group the data in memory
            var results = driverResults
                .GroupBy(x => new { x.RaceName })
                .SelectMany(g => g)
                .ToList();

            return results;
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
                        TrackName = r.TrackName,
                        RaceSeason = r.RaceSeason
                    }).ToList()
                })
                .ToListAsync();

            var finalResults = results.Select(g =>
            {
                var driverAverageStats = new DriverAverageStats
                {
                    DriverFullName = g.DriverFullName,
                    AverageStartPosition = (double)g.Results.Average(x => x.StartPosition / (trackWeights != null && trackWeights.ContainsKey(x.TrackName) ? trackWeights[x.TrackName] : 1)),
                    AveragePosition = (double)g.Results.Average(x => x.AveragePosition / (trackWeights != null && trackWeights.ContainsKey(x.TrackName) ? trackWeights[x.TrackName] : 1)),
                    AverageEndPosition = (double)g.Results.Average(x => x.EndPosition / (trackWeights != null && trackWeights.ContainsKey(x.TrackName) ? trackWeights[x.TrackName] : 1)),
                    AverageFastLaps = (double)g.Results.Average(x => x.FastLaps * (trackWeights != null && trackWeights.ContainsKey(x.TrackName) ? trackWeights[x.TrackName] : 1)),
                    AverageRating = (double)g.Results.Average(x => x.Rating * (trackWeights != null && trackWeights.ContainsKey(x.TrackName) ? trackWeights[x.TrackName] : 1)),
                    AverageLeadLaps = (double)g.Results.Average(x => x.LeadLaps * (trackWeights != null && trackWeights.ContainsKey(x.TrackName) ? trackWeights[x.TrackName] : 1)),
                    AveragePasses = (double)g.Results.Average(x => x.Passes * (trackWeights != null && trackWeights.ContainsKey(x.TrackName) ? trackWeights[x.TrackName] : 1)),
                    WinFinishes = g.Results.Count(x => x.EndPosition <= 1),
                    Top3Finishes = g.Results.Count(x => x.EndPosition <= 3),
                    Top5Finishes = g.Results.Count(x => x.EndPosition <= 5),
                    Top10Finishes = g.Results.Count(x => x.EndPosition <= 10),
                    Top20Finishes = g.Results.Count(x => x.EndPosition <= 20),
                    SampleSize = g.Results.Count,
                    RaceResults = g.Results
                    .Where(r => raceSeasons.Contains(r.RaceSeason.Value) && trackNames.Contains(r.TrackName))
                    .Select(r => new RaceResultStat
                    {
                        RaceSeason = r.RaceSeason,
                        TrackName = r.TrackName,
                        StartPosition = r.StartPosition,
                        AveragePosition = r.AveragePosition,
                        EndPosition = r.EndPosition,
                        FastLaps = r.FastLaps,
                        LeadLaps = r.LeadLaps,
                        Rating = r.Rating
                    }).ToList()

                };

                // Add new properties


                return driverAverageStats;
            }).ToList();

            return finalResults;
        }



    }
}
