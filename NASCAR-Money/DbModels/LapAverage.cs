using System;
using System.Collections.Generic;

namespace NASCAR_Money.DbModels;

public partial class LapAverage
{
    public int? RaceSeason { get; set; }

    public int? SeriesId { get; set; }

    public int? RaceId { get; set; }

    public int? TrackId { get; set; }

    public string? TrackName { get; set; }

    public string? RaceName { get; set; }

    public string? Title { get; set; }

    public string? Number { get; set; }

    public int? NascardriverId { get; set; }

    public string? Driver { get; set; }

    public string? FullName { get; set; }

    public string? Manufacturer { get; set; }

    public string? Sponsor { get; set; }

    public double? OverAllAvg { get; set; }

    public int? OverAllAvgRank { get; set; }

    public double? BestLapTime { get; set; }

    public int? BestLapRank { get; set; }

    public double? Con5Lap { get; set; }

    public int? Con5LapRank { get; set; }

    public double? Con10Lap { get; set; }

    public int? Con10LapRank { get; set; }

    public double? Con15Lap { get; set; }

    public int? Con15LapRank { get; set; }

    public double? Con20Lap { get; set; }

    public int? Con20LapRank { get; set; }

    public double? Con25Lap { get; set; }

    public int? Con25LapRank { get; set; }

    public double? Con30Lap { get; set; }

    public int? Con30LapRank { get; set; }

    public int PrimaryKey { get; set; }
}
