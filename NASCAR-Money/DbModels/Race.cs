namespace NASCAR_Money.DbModels;

public partial class Race
{
    public int RaceId { get; set; }

    public int? SeriesId { get; set; }

    public int? RaceSeason { get; set; }

    public string? RaceName { get; set; }

    public int? RaceTypeId { get; set; }

    public bool? RestrictorPlate { get; set; }

    public int? TrackId { get; set; }

    public string? TrackName { get; set; }

    public string? DateScheduled { get; set; }

    public string? RaceDate { get; set; }

    public string? QualifyingDate { get; set; }

    public string? TuneinDate { get; set; }

    public double? ScheduledDistance { get; set; }

    public double? ActualDistance { get; set; }

    public int? ScheduledLaps { get; set; }

    public int? ActualLaps { get; set; }

    public int? Stage1Laps { get; set; }

    public int? Stage2Laps { get; set; }

    public int? Stage3Laps { get; set; }

    public int? NumberOfCarsInField { get; set; }

    public int? PoleWinnerDriverId { get; set; }

    public double? PoleWinnerSpeed { get; set; }

    public int? NumberOfLeadChanges { get; set; }

    public int? NumberOfLeaders { get; set; }

    public int? NumberOfCautions { get; set; }

    public int? NumberOfCautionLaps { get; set; }

    public double? AverageSpeed { get; set; }

    public string? TotalRaceTime { get; set; }

    public string? MarginOfVictory { get; set; }

    public double? RacePurse { get; set; }

    public string? RaceComments { get; set; }

    public int? Attendance { get; set; }

    public int? MasterRaceId { get; set; }

    public bool? InspectionComplete { get; set; }

    public int? PlayoffRound { get; set; }

    public bool? IsQualifyingRace { get; set; }

    public int? QualifyingRaceNo { get; set; }

    public int? QualifyingRaceId { get; set; }

    public bool? HasQualifying { get; set; }

    public int? WinnerDriverId { get; set; }

    public string? PoleWinnerLaptime { get; set; }
}
