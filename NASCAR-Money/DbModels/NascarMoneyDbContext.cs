using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NASCAR_Money.DbModels;

public partial class NascarMoneyDbContext : DbContext
{
    public NascarMoneyDbContext()
    {
    }

    public NascarMoneyDbContext(DbContextOptions<NascarMoneyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Driver> Drivers { get; set; }

    public virtual DbSet<DriverResult> DriverResults { get; set; }

    public virtual DbSet<LapAverage> LapAverages { get; set; }

    public virtual DbSet<Race> Races { get; set; }

    public virtual DbSet<RaceResult> RaceResults { get; set; }

    public virtual DbSet<Track> Tracks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:nascarmoney.database.windows.net,1433;Initial Catalog=NascarMoneyDB;Persist Security Info=False;User ID=austin;Password=ghjghj72AW!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Driver>(entity =>
        {
            entity.HasKey(e => e.NascarDriverId).HasName("PK__drivers__38875FC5B1DB9B44");

            entity.ToTable("drivers");

            entity.Property(e => e.NascarDriverId)
                .ValueGeneratedNever()
                .HasColumnName("nascar_driver_id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Badge)
                .HasColumnType("text")
                .HasColumnName("badge");
            entity.Property(e => e.BadgeImage)
                .HasColumnType("text")
                .HasColumnName("badge_image");
            entity.Property(e => e.CareerStats)
                .HasColumnType("text")
                .HasColumnName("career_stats");
            entity.Property(e => e.Children)
                .HasColumnType("text")
                .HasColumnName("children");
            entity.Property(e => e.CrewChief)
                .HasColumnType("text")
                .HasColumnName("crew_chief");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Dob)
                .HasColumnType("text")
                .HasColumnName("dob");
            entity.Property(e => e.Dod)
                .HasColumnType("text")
                .HasColumnName("dod");
            entity.Property(e => e.DriverPage)
                .HasColumnType("text")
                .HasColumnName("driver_page");
            entity.Property(e => e.DriverSeries)
                .HasColumnType("text")
                .HasColumnName("driver_series");
            entity.Property(e => e.FiresuitImage)
                .HasColumnType("text")
                .HasColumnName("firesuit_image");
            entity.Property(e => e.FiresuitImageSmall)
                .HasColumnType("text")
                .HasColumnName("firesuit_image_small");
            entity.Property(e => e.FirstName)
                .HasColumnType("text")
                .HasColumnName("first_name");
            entity.Property(e => e.FullName)
                .HasColumnType("text")
                .HasColumnName("full_name");
            entity.Property(e => e.Hobbies)
                .HasColumnType("text")
                .HasColumnName("hobbies");
            entity.Property(e => e.HometownCity)
                .HasColumnType("text")
                .HasColumnName("hometown_city");
            entity.Property(e => e.HometownCountry)
                .HasColumnType("text")
                .HasColumnName("hometown_country");
            entity.Property(e => e.HometownState)
                .HasColumnType("text")
                .HasColumnName("hometown_state");
            entity.Property(e => e.Image)
                .HasColumnType("text")
                .HasColumnName("image");
            entity.Property(e => e.ImageSmall)
                .HasColumnType("text")
                .HasColumnName("image_small");
            entity.Property(e => e.ImageTransparent)
                .HasColumnType("text")
                .HasColumnName("image_transparent");
            entity.Property(e => e.IntegratedSponsor)
                .HasColumnType("text")
                .HasColumnName("integrated_sponsor");
            entity.Property(e => e.IntegratedSponsorName)
                .HasColumnType("text")
                .HasColumnName("integrated_sponsor_name");
            entity.Property(e => e.IntegratedSponsorUrl)
                .HasColumnType("text")
                .HasColumnName("integrated_sponsor_url");
            entity.Property(e => e.LapsLed)
                .HasColumnType("text")
                .HasColumnName("laps_led");
            entity.Property(e => e.LastName)
                .HasColumnType("text")
                .HasColumnName("last_name");
            entity.Property(e => e.Manufacturer)
                .HasColumnType("text")
                .HasColumnName("manufacturer");
            entity.Property(e => e.ManufacturerSmall)
                .HasColumnType("text")
                .HasColumnName("manufacturer_small");
            entity.Property(e => e.NoWins)
                .HasColumnType("text")
                .HasColumnName("no_wins");
            entity.Property(e => e.PlayoffPoints)
                .HasColumnType("text")
                .HasColumnName("playoff_points");
            entity.Property(e => e.PlayoffRank)
                .HasColumnType("text")
                .HasColumnName("playoff_rank");
            entity.Property(e => e.Points)
                .HasColumnType("text")
                .HasColumnName("points");
            entity.Property(e => e.PointsBehind).HasColumnName("points_behind");
            entity.Property(e => e.Poles)
                .HasColumnType("text")
                .HasColumnName("poles");
            entity.Property(e => e.Rank)
                .HasColumnType("text")
                .HasColumnName("rank");
            entity.Property(e => e.ResidingCity)
                .HasColumnType("text")
                .HasColumnName("residing_city");
            entity.Property(e => e.ResidingCountry)
                .HasColumnType("text")
                .HasColumnName("residing_country");
            entity.Property(e => e.ResidingState)
                .HasColumnType("text")
                .HasColumnName("residing_state");
            entity.Property(e => e.RookieYearSeries1).HasColumnName("rookie_year_series_1");
            entity.Property(e => e.RookieYearSeries2).HasColumnName("rookie_year_series_2");
            entity.Property(e => e.RookieYearSeries3).HasColumnName("rookie_year_series_3");
            entity.Property(e => e.SecondaryImage)
                .HasColumnType("text")
                .HasColumnName("secondary_image");
            entity.Property(e => e.SeriesLogo)
                .HasColumnType("text")
                .HasColumnName("series_logo");
            entity.Property(e => e.ShortName)
                .HasColumnType("text")
                .HasColumnName("short_name");
            entity.Property(e => e.SillySeasonChange)
                .HasColumnType("text")
                .HasColumnName("silly_season_change");
            entity.Property(e => e.SillySeasonChangeDescription)
                .HasColumnType("text")
                .HasColumnName("silly_season_change_description");
            entity.Property(e => e.StageWins)
                .HasColumnType("text")
                .HasColumnName("stage_wins");
            entity.Property(e => e.Team)
                .HasColumnType("text")
                .HasColumnName("team");
            entity.Property(e => e.Top10)
                .HasColumnType("text")
                .HasColumnName("top10");
            entity.Property(e => e.Top5)
                .HasColumnType("text")
                .HasColumnName("top5");
            entity.Property(e => e.TwitterHandle)
                .HasColumnType("text")
                .HasColumnName("twitter_handle");
        });

        modelBuilder.Entity<DriverResult>(entity =>
        {
            entity.HasIndex(e => new { e.RaceSeason, e.SeriesId, e.RaceId, e.DriverId }, "idx_unique_fields").IsUnique();

            entity.Property(e => e.DriverFullName).IsUnicode(false);
            entity.Property(e => e.DriverId).HasColumnName("DriverID");
            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.RaceName)
                .IsUnicode(false)
                .HasColumnName("race_name");
            entity.Property(e => e.RaceSeason).HasColumnName("race_season");
            entity.Property(e => e.SeriesId).HasColumnName("series_id");
            entity.Property(e => e.TrackName)
                .IsUnicode(false)
                .HasColumnName("track_name");
        });

        modelBuilder.Entity<LapAverage>(entity =>
        {
            entity.HasKey(e => e.PrimaryKey).HasName("PK__LapAvera__A2D9E564FDECD5BB");

            entity.HasIndex(e => new { e.SeriesId, e.RaceId, e.Title, e.NascardriverId }, "UC_LapAverages").IsUnique();

            entity.Property(e => e.Driver).IsUnicode(false);
            entity.Property(e => e.FullName).IsUnicode(false);
            entity.Property(e => e.Manufacturer).IsUnicode(false);
            entity.Property(e => e.NascardriverId).HasColumnName("NASCARDriverID");
            entity.Property(e => e.Number).IsUnicode(false);
            entity.Property(e => e.RaceId).HasColumnName("race_id");
            entity.Property(e => e.RaceName)
                .IsUnicode(false)
                .HasColumnName("race_name");
            entity.Property(e => e.RaceSeason).HasColumnName("race_season");
            entity.Property(e => e.SeriesId).HasColumnName("series_id");
            entity.Property(e => e.Sponsor).IsUnicode(false);
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.TrackId).HasColumnName("track_id");
            entity.Property(e => e.TrackName)
                .IsUnicode(false)
                .HasColumnName("track_name");
        });

        modelBuilder.Entity<Race>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Race");

            entity.HasIndex(e => new { e.RaceId, e.SeriesId, e.RaceSeason }, "UC_Race").IsUnique();

            entity.Property(e => e.ActualDistance).HasColumnName("actual_distance");
            entity.Property(e => e.ActualLaps).HasColumnName("actual_laps");
            entity.Property(e => e.Attendance).HasColumnName("attendance");
            entity.Property(e => e.AverageSpeed).HasColumnName("average_speed");
            entity.Property(e => e.DateScheduled)
                .IsUnicode(false)
                .HasColumnName("date_scheduled");
            entity.Property(e => e.HasQualifying).HasColumnName("has_qualifying");
            entity.Property(e => e.InspectionComplete).HasColumnName("inspection_complete");
            entity.Property(e => e.IsQualifyingRace).HasColumnName("is_qualifying_race");
            entity.Property(e => e.MarginOfVictory)
                .HasMaxLength(50)
                .HasColumnName("margin_of_victory");
            entity.Property(e => e.MasterRaceId).HasColumnName("master_race_id");
            entity.Property(e => e.NumberOfCarsInField).HasColumnName("number_of_cars_in_field");
            entity.Property(e => e.NumberOfCautionLaps).HasColumnName("number_of_caution_laps");
            entity.Property(e => e.NumberOfCautions).HasColumnName("number_of_cautions");
            entity.Property(e => e.NumberOfLeadChanges).HasColumnName("number_of_lead_changes");
            entity.Property(e => e.NumberOfLeaders).HasColumnName("number_of_leaders");
            entity.Property(e => e.PlayoffRound).HasColumnName("playoff_round");
            entity.Property(e => e.PoleWinnerDriverId).HasColumnName("pole_winner_driver_id");
            entity.Property(e => e.PoleWinnerLaptime)
                .IsUnicode(false)
                .HasColumnName("pole_winner_laptime");
            entity.Property(e => e.PoleWinnerSpeed).HasColumnName("pole_winner_speed");
            entity.Property(e => e.QualifyingDate)
                .IsUnicode(false)
                .HasColumnName("qualifying_date");
            entity.Property(e => e.QualifyingRaceId).HasColumnName("qualifying_race_id");
            entity.Property(e => e.QualifyingRaceNo).HasColumnName("qualifying_race_no");
            entity.Property(e => e.RaceComments)
                .IsUnicode(false)
                .HasColumnName("race_comments");
            entity.Property(e => e.RaceDate)
                .IsUnicode(false)
                .HasColumnName("race_date");
            entity.Property(e => e.RaceId).HasColumnName("race_id");
            entity.Property(e => e.RaceName)
                .IsUnicode(false)
                .HasColumnName("race_name");
            entity.Property(e => e.RacePurse).HasColumnName("race_purse");
            entity.Property(e => e.RaceSeason).HasColumnName("race_season");
            entity.Property(e => e.RaceTypeId).HasColumnName("race_type_id");
            entity.Property(e => e.RestrictorPlate).HasColumnName("restrictor_plate");
            entity.Property(e => e.ScheduledDistance).HasColumnName("scheduled_distance");
            entity.Property(e => e.ScheduledLaps).HasColumnName("scheduled_laps");
            entity.Property(e => e.SeriesId).HasColumnName("series_id");
            entity.Property(e => e.Stage1Laps).HasColumnName("stage_1_laps");
            entity.Property(e => e.Stage2Laps).HasColumnName("stage_2_laps");
            entity.Property(e => e.Stage3Laps).HasColumnName("stage_3_laps");
            entity.Property(e => e.TotalRaceTime)
                .IsUnicode(false)
                .HasColumnName("total_race_time");
            entity.Property(e => e.TrackId).HasColumnName("track_id");
            entity.Property(e => e.TrackName)
                .IsUnicode(false)
                .HasColumnName("track_name");
            entity.Property(e => e.TuneinDate)
                .IsUnicode(false)
                .HasColumnName("tunein_date");
            entity.Property(e => e.WinnerDriverId).HasColumnName("winner_driver_id");
        });

        modelBuilder.Entity<RaceResult>(entity =>
        {
            entity.HasKey(e => new { e.RaceId, e.DriverId }).HasName("PK__RaceResu__5AE0CA066C9B8A6A");

            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.DriverId).HasColumnName("DriverID");
        });

        modelBuilder.Entity<Track>(entity =>
        {
            entity.HasKey(e => e.TrackId).HasName("PK__mytable__24ECC82E630DB26E");

            entity.Property(e => e.TrackId)
                .ValueGeneratedNever()
                .HasColumnName("track_id");
            entity.Property(e => e.Address)
                .HasMaxLength(38)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.BackstretchLength).HasColumnName("backstretch_length");
            entity.Property(e => e.Capacity)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("capacity");
            entity.Property(e => e.CautionCarSpeed).HasColumnName("caution_car_speed");
            entity.Property(e => e.City)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.FrontstretchLength).HasColumnName("frontstretch_length");
            entity.Property(e => e.Length)
                .HasColumnType("numeric(5, 3)")
                .HasColumnName("length");
            entity.Property(e => e.Races)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("races");
            entity.Property(e => e.SeatingCapacity).HasColumnName("seating_capacity");
            entity.Property(e => e.State)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.TicketsUrl)
                .HasMaxLength(114)
                .IsUnicode(false)
                .HasColumnName("tickets_url");
            entity.Property(e => e.TicketsUrlNewWindow)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("tickets_url_new_window");
            entity.Property(e => e.TrackBanking)
                .HasMaxLength(133)
                .IsUnicode(false)
                .HasColumnName("track_banking");
            entity.Property(e => e.TrackDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("track_description");
            entity.Property(e => e.TrackImage)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("track_image");
            entity.Property(e => e.TrackImageThumbnail)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("track_image_thumbnail");
            entity.Property(e => e.TrackLogo)
                .HasMaxLength(104)
                .IsUnicode(false)
                .HasColumnName("track_logo");
            entity.Property(e => e.TrackMajorEvents)
                .HasMaxLength(56)
                .IsUnicode(false)
                .HasColumnName("track_major_events");
            entity.Property(e => e.TrackName)
                .HasMaxLength(39)
                .IsUnicode(false)
                .HasColumnName("track_name");
            entity.Property(e => e.TrackNumTurns).HasColumnName("track_num_turns");
            entity.Property(e => e.TrackOwner)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("track_owner");
            entity.Property(e => e.TrackShortName)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("track_short_name");
            entity.Property(e => e.TrackSurface)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("track_surface");
            entity.Property(e => e.TrackType)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("track_type");
            entity.Property(e => e.TrackUrl)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("track_url");
            entity.Property(e => e.TrackUrlNewWindow)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("track_url_new_window");
            entity.Property(e => e.YearBuilt).HasColumnName("year_built");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("zip");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
