using NASCAR_Money.DbModels;

namespace NASCAR_Money.Services
{
    public interface ITrackService
    {
        Task<List<Track>> GetTracks();
        Task<List<Race>> GetRaces();
    }
}
