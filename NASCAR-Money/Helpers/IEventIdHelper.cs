namespace NASCAR_Money.Helpers
{
    public interface IEventIdHelper
    {
        Task<int> GetUpcomingCupEventId(DateTime time);
        Task<int> GetUpcomingXfinityEventId(DateTime time);
        Task<int> GetUpcomingTruckEventId(DateTime time);
        Task<int> GetPreviousCupEventId(DateTime time);
        Task<int> GetPreviousXfinityEventId(DateTime time);
        Task<int> GetPreviousTruckEventId(DateTime time);
    }
}
