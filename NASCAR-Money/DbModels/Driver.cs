using System;
using System.Collections.Generic;

namespace NASCAR_Money.DbModels;

public partial class Driver
{
    public int NascarDriverId { get; set; }

    public string? FullName { get; set; }

    public string? Team { get; set; }

    public string? DriverSeries { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? SeriesLogo { get; set; }

    public string? ShortName { get; set; }

    public string? Description { get; set; }

    public string? Dob { get; set; }

    public string? Dod { get; set; }

    public string? HometownCity { get; set; }

    public string? CrewChief { get; set; }

    public string? HometownState { get; set; }

    public string? HometownCountry { get; set; }

    public int? RookieYearSeries1 { get; set; }

    public int? RookieYearSeries2 { get; set; }

    public int? RookieYearSeries3 { get; set; }

    public string? Hobbies { get; set; }

    public string? Children { get; set; }

    public string? TwitterHandle { get; set; }

    public string? ResidingCity { get; set; }

    public string? ResidingState { get; set; }

    public string? ResidingCountry { get; set; }

    public string? Badge { get; set; }

    public string? BadgeImage { get; set; }

    public string? Manufacturer { get; set; }

    public string? ManufacturerSmall { get; set; }

    public string? Image { get; set; }

    public string? ImageSmall { get; set; }

    public string? ImageTransparent { get; set; }

    public string? SecondaryImage { get; set; }

    public string? FiresuitImage { get; set; }

    public string? FiresuitImageSmall { get; set; }

    public string? CareerStats { get; set; }

    public string? DriverPage { get; set; }

    public int? Age { get; set; }

    public string? Rank { get; set; }

    public string? Points { get; set; }

    public int? PointsBehind { get; set; }

    public string? NoWins { get; set; }

    public string? Poles { get; set; }

    public string? Top5 { get; set; }

    public string? Top10 { get; set; }

    public string? LapsLed { get; set; }

    public string? StageWins { get; set; }

    public string? PlayoffPoints { get; set; }

    public string? PlayoffRank { get; set; }

    public string? IntegratedSponsorName { get; set; }

    public string? IntegratedSponsor { get; set; }

    public string? IntegratedSponsorUrl { get; set; }

    public string? SillySeasonChange { get; set; }

    public string? SillySeasonChangeDescription { get; set; }

    public virtual ICollection<RaceDetail> RaceDetails { get; set; } = new List<RaceDetail>();
}
