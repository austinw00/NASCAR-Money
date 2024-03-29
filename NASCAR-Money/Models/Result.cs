﻿namespace NASCAR_Money.Models
{
    public class Result
    {
        public int result_id { get; set; }
        public int finishing_position { get; set; }
        public int starting_position { get; set; }
        public string car_number { get; set; }
        public string driver_fullname { get; set; }
        public int driver_id { get; set; }
        public string driver_hometown { get; set; }
        public string hometown_city { get; set; }
        public string hometown_state { get; set; }
        public string hometown_country { get; set; }
        public int team_id { get; set; }
        public string team_name { get; set; }
        public int qualifying_order { get; set; }
        public int qualifying_position { get; set; }
        public double qualifying_speed { get; set; }
        public int laps_led { get; set; }
        public int times_led { get; set; }
        public string car_make { get; set; }
        public string car_model { get; set; }
        public string sponsor { get; set; }
        public int points_earned { get; set; }
        public int playoff_points_earned { get; set; }
        public int laps_completed { get; set; }
        public string finishing_status { get; set; }
        public int winnings { get; set; }
        public int series_id { get; set; }
        public int race_season { get; set; }
        public int race_id { get; set; }
        public string owner_fullname { get; set; }
        public int crew_chief_id { get; set; }
        public string crew_chief_fullname { get; set; }
        public int points_position { get; set; }
        public int points_delta { get; set; }
        public int owner_id { get; set; }
        public string official_car_number { get; set; }
        public bool disqualified { get; set; }
        public int diff_laps { get; set; }
        public int diff_time { get; set; }
        public int pit_box { get; set; }
        public int stage_points { get; set; }
        public int run_id { get; set; }
        public string vehicle_number { get; set; }
        public string manufacturer { get; set; }
        public string driver_name { get; set; }
        public double best_lap_time { get; set; }
        public double best_lap_speed { get; set; }
        public int best_lap_number { get; set; }
        public string comment { get; set; }
        public double delta_leader { get; set; }
    }
}
