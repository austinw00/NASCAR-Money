using NASCAR_Money.Data.NascarCache;
using NASCAR_Money.Models;

namespace NASCAR_Money.Helpers
{
    public class DriversHelper : IDriversHelper
    {
        private readonly ICacheService _cacheService;

        public DriversHelper(ICacheService cacheService)
        {
            _cacheService = cacheService;
        }

        public async Task<List<DriverData>> GetDriversList()
        {
            Drivers drivers = await _cacheService.GetDriversAsync();
            List<DriverData> driverList = drivers.response;
            driverList.OrderBy(d => d.Last_Name);

            return driverList;
        }

        public async Task<DriverData> GetDriverById(int driverId)
        {
            List<DriverData> driverList = await GetDriversList();
            DriverData driver = driverList.Where(d => d.Driver_ID == driverId).FirstOrDefault();
            return driver;
        }

        public async Task<List<DriverData>> GetCupDriversList()
        {
            List<DriverData> driverList = await GetDriversList();
            List<DriverData> cupDrivers = driverList.Where(d => d.Driver_Series == "nascar-cup-series").ToList();
            return cupDrivers;
        }

        public async Task<List<DriverData>> GetXfinityDriversList()
        {
            List<DriverData> driverList = await GetDriversList();
            List<DriverData> xfinityDrivers = driverList.Where(d => d.Driver_Series == "nascar-xfinity-series").ToList();
            return xfinityDrivers;
        }

        public async Task<List<DriverData>> GetTruckDriversList()
        {
            List<DriverData> driverList = await GetDriversList();
            List<DriverData> truckDrivers = driverList.Where(d => d.Driver_Series == "nascar-craftsman-truck-series").ToList();
            return truckDrivers;
        }

        public async Task<List<DriverData>> GetCurrentCupDriversList()
        {
            List<DriverData> cupDrivers = await GetCupDriversList();
            List<DriverData> currentCupDrivers = cupDrivers.Where(
                d => d.Driver_Series == "nascar-cup-series" &&
                !string.IsNullOrEmpty(d.Badge_Image) &&
                !string.IsNullOrEmpty(d.Driver_Page) &&
                !string.IsNullOrEmpty(d.Team)).ToList();
            return currentCupDrivers;
        }

        public async Task<List<DriverData>> GetCurrentXfinityDriversList()
        {
            List<DriverData> xfinityDrivers = await GetXfinityDriversList();
            List<DriverData> currentXfinityDrivers = xfinityDrivers.Where(
                d => d.Driver_Series == "nascar-xfinity-series" &&
                !string.IsNullOrEmpty(d.Badge_Image) &&
                !string.IsNullOrEmpty(d.Driver_Page) &&
                !string.IsNullOrEmpty(d.Team)).ToList();
            return currentXfinityDrivers;
        }

        public async Task<List<DriverData>> GetCurrentTruckDriversList()
        {
            List<DriverData> truckDrivers = await GetTruckDriversList();
            List<DriverData> currentTruckDrivers = truckDrivers.Where(
                d => d.Driver_Series == "nascar-craftsman-truck-series" &&
                !string.IsNullOrEmpty(d.Badge_Image) &&
                !string.IsNullOrEmpty(d.Driver_Page) &&
                !string.IsNullOrEmpty(d.Team)).ToList();
            return currentTruckDrivers;
        }
    }
}
