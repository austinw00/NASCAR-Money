using NASCAR_Money.DbModels;

namespace NASCAR_Money.Services
{
    public class TrackService : ITrackService
    {
        private readonly NascarMoneyDbContext _context;

        public TrackService(NascarMoneyDbContext context)
        {
            _context = context;
        }

        public async Task<List<Track>> GetTracks()
        {
            return _context.Tracks.ToList();
        }
    }
}
