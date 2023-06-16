using NASCAR_Money.DbModels;

namespace NASCAR_Money.Models.ViewModels
{
    public class RaceCenterViewModel
    {
        public Response scheduleCombinedFeed { get; set; }
        public WeekendFeed? weekendFeed { get; set; }
        //public LapAverages? lapAverages { get; set; }
        public Track? trackInfo { get; set; }
        public RaceListBasic? raceListBasic { get; set; }
    }
}
