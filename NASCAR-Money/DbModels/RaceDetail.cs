using System;
using System.Collections.Generic;

namespace NASCAR_Money.DbModels;

public partial class RaceDetail
{
    public int Id { get; set; }

    public int? RaceId { get; set; }

    public int? DriverId { get; set; }

    public int? LapNumber { get; set; }

    public double? LapSpeed { get; set; }

    public double? LapTime { get; set; }

    public int? RunningPos { get; set; }

    public int? FlagState { get; set; }

    public virtual Driver? Driver { get; set; }

    public virtual Race? Race { get; set; }
}
