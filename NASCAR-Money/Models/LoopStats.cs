using Newtonsoft.Json;

namespace NASCAR_Money.Models
{
    public class LoopDriverData
    {
        public int driver_id { get; set; }
        public int start_ps { get; set; }
        public int mid_ps { get; set; }
        public int ps { get; set; }
        public int closing_ps { get; set; }
        public int closing_laps_diff { get; set; }
        public int best_ps { get; set; }
        public int worst_ps { get; set; }
        public double avg_ps { get; set; }
        public int passes_gf { get; set; }
        public int passing_diff { get; set; }
        public int passed_gf { get; set; }
        public int quality_passes { get; set; }
        public int fast_laps { get; set; }
        public int top15_laps { get; set; }
        public int lead_laps { get; set; }
        public int laps { get; set; }
        public double rating { get; set; }
    }

    public class LoopStats
    {
        public int race_id { get; set; }
        public string race_name { get; set; }
        public int series_id { get; set; }
        public int sch_laps { get; set; }
        public int act_laps { get; set; }
        [JsonProperty("Driver")]
        public List<LoopDriverData> drivers { get; set; }
    }
}
