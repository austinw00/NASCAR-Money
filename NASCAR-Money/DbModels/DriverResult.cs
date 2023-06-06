using System;
using System.Collections.Generic;

namespace NASCAR_Money.DbModels;

public partial class DriverResult
{
    public int? RaceSeason { get; set; }

    public int? SeriesId { get; set; }

    public string? TrackName { get; set; }

    public string? RaceName { get; set; }

    public int RaceId { get; set; }

    public int DriverId { get; set; }

    public int? StartPosition { get; set; }

    public int? MidPosition { get; set; }

    public int? EndPosition { get; set; }

    public int? BestPosition { get; set; }

    public int? WorstPosition { get; set; }

    public float? AveragePosition { get; set; }

    public int? Passes { get; set; }

    public int? FastLaps { get; set; }

    public int? Top15Laps { get; set; }

    public int? LeadLaps { get; set; }

    public int? TotalLaps { get; set; }

    public float? Rating { get; set; }

    public string? DriverFullName { get; set; }

    public int DriverResultId { get; set; }
}
