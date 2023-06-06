using System;
using System.Collections.Generic;

namespace NASCAR_Money.DbModels;

public partial class Track
{
    public int TrackId { get; set; }

    public string TrackName { get; set; } = null!;

    public string TrackSurface { get; set; } = null!;

    public string TrackType { get; set; } = null!;

    public string? TrackBanking { get; set; }

    public int YearBuilt { get; set; }

    public string? TrackDescription { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public int FrontstretchLength { get; set; }

    public int BackstretchLength { get; set; }

    public bool SeatingCapacity { get; set; }

    public string? TrackOwner { get; set; }

    public string? Races { get; set; }

    public decimal Length { get; set; }

    public string? Zip { get; set; }

    public string? Address { get; set; }

    public int CautionCarSpeed { get; set; }

    public string? TrackImage { get; set; }

    public string? TrackImageThumbnail { get; set; }

    public string? TrackLogo { get; set; }

    public string? TrackMajorEvents { get; set; }

    public int? TrackNumTurns { get; set; }

    public string? Capacity { get; set; }

    public string TicketsUrl { get; set; } = null!;

    public string TicketsUrlNewWindow { get; set; } = null!;

    public string TrackUrl { get; set; } = null!;

    public string TrackUrlNewWindow { get; set; } = null!;

    public string? TrackShortName { get; set; }
}
