using Flurl.Http.Testing;
using HVISAPIWrapper.Client.Services;
using HVISAPIWrapper.Test.DataFactories;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace HVISAPIWrapper.Test
{
    public class VideoSettingsTests
    {
        private HttpTest _httpTest;
        private Mock<IVideoSettingsService> _mockVideoSettingsService;

        public VideoSettingsTests()
        {
            _mockVideoSettingsService = new Mock<IVideoSettingsService>();

            //_sut = new VideoSettingsService(new Client.HIKISAPIClientConfiguration()
            //{
            //    DeviceUrl = "",
            //    Password = "",
            //    Port = "",
            //    UserName = ""
            //});

            _httpTest = new HttpTest();
        }

        [Fact]
        public async Task GetVideoSettings()
        {

            // Arrange
            //var okResult = FixtureConfig.Fixture.Create<OkApiResult<List<WorkerAvailabilityIntervals>>>();
            var test = VideoSettingsFactory.GetImageChannel();
            _mockVideoSettingsService.Setup(x => x.GetVideoSettings(1)).ReturnsAsync(test);

            //_httpTest.RespondWithJson(okResult);

            //var result = await _sut.GetVideoSettings(1);

            // Assert
            //Assert.Equal(okResult.Data, result);
        }
    }
}
