using Moq;
using NASCAR_Money.Data.NascarCache;
using NASCAR_Money.Helpers;
using NASCAR_Money.Models;
using NUnit.Framework;

namespace NASCAR_Money.Tests
{
    public class EventIdHelperTests
    {
        private Mock<ICacheService> _mockCacheService;

        [SetUp]
        public void Setup()
        {
            _mockCacheService = new Mock<ICacheService>();
        }

        [Test]
        public async Task GetUpcomingCupEventId_ShouldReturnExpectedEventId()
        {
            // Arrange
            var time = new DateTime(2023, 5, 18);
            var expectedEventId = 5286;  // change this as appropriate
            var raceListBasic = new RaceListBasic
            {
                series_1 = new List<Series1>
                {
                    new Series1 { date_scheduled = new DateTime(2023, 6, 2), race_id = 2 },
                    new Series1 { date_scheduled = new DateTime(2023, 19, 5), race_id = expectedEventId },
                    new Series1 { date_scheduled = new DateTime(2023, 6, 8), race_id = 1 },

                }
            };

            _mockCacheService
                .Setup(s => s.GetRaceListBasicAsync(It.IsAny<int>()))
                .ReturnsAsync(raceListBasic);

            var eventIdHelper = new EventIdHelper(_mockCacheService.Object);

            // Act
            var result = await eventIdHelper.GetUpcomingCupEventId(time);

            // Assert
            Assert.AreEqual(expectedEventId, result);
        }
    }
}
