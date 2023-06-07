namespace NASCAR_Money.Models
{
    public class DriverAverageStats
    {
        public string DriverFullName { get; set; }
        public double? AverageStartPosition { get; set; }
        public double? AveragePosition { get; set; }
        public double? AverageEndPosition { get; set; }
        public double? AverageRating { get; set; }
        public double? AverageLeadLaps { get; set; }
        public double? AverageFastLaps { get; set; }
        public double? AveragePasses { get; set; }
        public int? WinFinishes { get; set; }
        public int? Top3Finishes { get; set; }
        public int? Top5Finishes { get; set; }
        public int? Top10Finishes { get; set; }
        public int? Top20Finishes { get; set; }
        public int? SampleSize { get; set; }
        public List<RaceResultStat> RaceResults { get; set; }

    }

    public class RaceResultStat
    {
        public int Year { get; set; }
        public string TrackName { get; set; }
        public int FinishPosition { get; set; }
    }
}
