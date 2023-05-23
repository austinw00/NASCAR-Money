using NASCAR_Money.Models;
using Newtonsoft.Json;
namespace NASCAR_Money.Data.NascarCache
{
    public class CacheService : ICacheService
    {
        private readonly HttpClient _httpClient;

        public CacheService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<LiveFeed> GetLiveFeedAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("https://cf.nascar.com/live/feeds/live-feed.json");

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = await response.Content.ReadAsStringAsync();
                LiveFeed liveFeed = JsonConvert.DeserializeObject<LiveFeed>(jsonContent);
                return liveFeed;
            }

            return null;
        }

        public async Task<LiveOps> GetLiveOpsAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("https://cf.nascar.com/live-ops/live-ops.json");

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = await response.Content.ReadAsStringAsync();
                LiveOps liveOps = JsonConvert.DeserializeObject<LiveOps>(jsonContent);
                return liveOps;
            }

            return null;
        }

        public async Task<LapAverages> GetLapAveragesAsync(int year, int seriesId, int eventId)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"https://cf.nascar.com/cacher/{year}/{seriesId}/{eventId}/lap-averages.json");

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = await response.Content.ReadAsStringAsync();
                LapAverages lapAverages = JsonConvert.DeserializeObject<LapAverages>(jsonContent);
                return lapAverages;
            }

            return null;
        }

        public async Task<WeekendFeed> GetWeekendFeedAsync(int year, int seriesId, int eventId)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"https://cf.nascar.com/cacher/{year}/{seriesId}/{eventId}/weekend-feed.json");

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = await response.Content.ReadAsStringAsync();
                WeekendFeed weekendFeed = JsonConvert.DeserializeObject<WeekendFeed>(jsonContent);
                return weekendFeed;
            }

            return null;
        }

        public async Task<LoopStats> GetLoopStatsAsync(int year, int seriesId, int eventId)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"https://cf.nascar.com/loopstats/prod/{year}/{seriesId}/{eventId}.json");

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = await response.Content.ReadAsStringAsync();
                LoopStats loopStats = JsonConvert.DeserializeObject<LoopStats>(jsonContent);
                return loopStats;
            }

            return null;
        }

        public async Task<RaceListBasic> GetRaceListBasicAsync(int year)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"https://cf.nascar.com/cacher/{year}/race_list_basic.json");

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = await response.Content.ReadAsStringAsync();
                RaceListBasic raceListBasic = JsonConvert.DeserializeObject<RaceListBasic>(jsonContent);
                return raceListBasic;
            }

            return null;
        }

        public async Task<ScheduleCombinedFeed> GetScheduleCombinedFeedAsync(int year, int seriesId)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"https://cf.nascar.com/cacher/{year}/{seriesId}/schedule-combined-feed.json");

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = await response.Content.ReadAsStringAsync();
                ScheduleCombinedFeed scheduleCombinedFeed = JsonConvert.DeserializeObject<ScheduleCombinedFeed>(jsonContent);
                return scheduleCombinedFeed;
            }

            return null;
        }


    }
}
