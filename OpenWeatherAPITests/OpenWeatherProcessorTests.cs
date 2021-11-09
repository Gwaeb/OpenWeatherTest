using OpenWeatherAPI;
using System;
using Xunit;

namespace OpenWeatherAPITests
{
    public class OpenWeatherProcessorTests
    {
        [Fact]
        public async void GetOneCallAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {
            OpenWeatherProcessor openWeatherProcessor = OpenWeatherProcessor.Instance;

            await Assert.ThrowsAsync<ArgumentException>(openWeatherProcessor.GetOneCallAsync);
        }

        [Fact]
        public async void GetCurrentWeatherAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {
            OpenWeatherProcessor openWeatherProcessor = OpenWeatherProcessor.Instance;

            await Assert.ThrowsAsync<ArgumentException>(openWeatherProcessor.GetCurrentWeatherAsync);
        }

        [Fact]
        public async void GetOneCallAsync_IfApiHelperNotInitialized_ThrowArgumentException()
        {
            OpenWeatherProcessor openWeatherProcessor = OpenWeatherProcessor.Instance;

            await Assert.ThrowsAsync<ArgumentException>(openWeatherProcessor.GetOneCallAsync);
        }

        [Fact]
        public async void GetCurrentWeatherAsync_IfApiHelperNotInitialized_ThrowArgumentException()
        {
            OpenWeatherProcessor openWeatherProcessor = OpenWeatherProcessor.Instance;

            await Assert.ThrowsAsync<ArgumentException>(openWeatherProcessor.GetCurrentWeatherAsync);
        }

    }
}
