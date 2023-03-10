using FluentAssertions;
using NetworkUtility.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NetworkUtility.Tests.PingTests
{
    public class NetworkServiceTest
    {
        [Fact]
        public void NetworkServiceSendPingReturnString()
        {
            //Arrange
            var pingService = new NetworkService();
            //Act
            var result = pingService.SendPing();
            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Ping Sent:");
            result.Should().Contain("Ping", Exactly.Once());
            result.Should().Contain("Sent", Exactly.Once());
        }

        [Theory]
        [InlineData(3, 9)]
        public void NetworkServicePingTimeOutReturnInt(int a, int b)
        {
            //Arrange
            var pingService = new NetworkService();
            //Act
            var pingResult = pingService.PingTimeout(a, b);
            //Assert
            pingResult.Should().BeGreaterThanOrEqualTo(12);
            pingResult.Should().NotBeInRange(-1000000, 0);
        }
    }
}
