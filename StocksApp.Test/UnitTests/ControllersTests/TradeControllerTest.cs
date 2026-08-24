using AutoFixture;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;
using StocksApp.Server.Controllers;
using StocksApp.Server.DTOs;
using StocksApp.Server.Options;
using StocksApp.Server.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Text;

namespace StocksApp.Test.UnitTests.ControllersTests
{
    public class TradeControllerTest
    {
        private readonly IFixture _fixture;
        private readonly ITestOutputHelper _outputHelper;
        private readonly IStockService _stockService;
        private readonly IFinnhubService _finnhubService;
        private readonly IOptionsSnapshot<TradingOptions> _tradingOptions;

        private readonly Mock<IStockService> _stockServiceMock;
        private readonly Mock<IFinnhubService> _finnhubServiceMock;
        private readonly Mock<IOptionsSnapshot<TradingOptions>> _tradingOptionsMock;
        //private readonly IOrdersPdfGenerator _ordersPdfGenerator;

        public TradeControllerTest(ITestOutputHelper testOutputHelper)
        {
            _fixture = new Fixture();
            _outputHelper = testOutputHelper;

            _stockServiceMock = new Mock<IStockService>();
            _stockService = _stockServiceMock.Object;

            _finnhubServiceMock = new Mock<IFinnhubService>();
            _finnhubService = _finnhubServiceMock.Object;

            _tradingOptionsMock = new Mock<IOptionsSnapshot<TradingOptions>>();
            _tradingOptions = _tradingOptionsMock.Object;
        }

        [Fact]
        public async Task GetCompanyProfile_ToBeSuccessful()
        {
            // Arrange
            var controller = new TradeController(_finnhubService, _stockService, null!, _tradingOptions,null!);
            var companyProfile = _fixture.Create<TradeCompanyProfile>();
            var tradingOptions = _fixture.Create<TradingOptions>();
   
            _tradingOptionsMock.Setup(options => options.Value).Returns(tradingOptions);

            _finnhubServiceMock.Setup(finnhub => finnhub.GetCompanyProfile(tradingOptions.DefaultFinnhubSymbol!))
                .ReturnsAsync(companyProfile);

            _finnhubServiceMock.Setup(finnhub => finnhub.GetStockPriceQuote(tradingOptions.DefaultFinnhubSymbol!))
                .ReturnsAsync(new Dictionary<string, object?>() { ["h"] = 100.0 });

            // Act
            var response = await controller.CompanyProfile();

            // Assert
            response.Should().NotBeNull();
            var result = response.Should().BeOfType<ActionResult<StockTradeDTO>>();
            
        }

        [Fact]
        public async Task CreateBuyOrder_WithValidData_ToBeSuccessful()
        {
            // Arrange
            var controller = new TradeController(_finnhubService, _stockService, null!, _tradingOptions,null!);
            var buyOrderRequest = _fixture.Build<BuyOrderRequest>()
                .With(bo => bo.DateAndTimeOfOrder, DateTime.Parse("2023-01-01T00:00:00"))
                .With(bo => bo.Quantity, Convert.ToDouble(100))
                .Create();
            var buyOrderResponse_expected = buyOrderRequest.ToBuyOrder().ToBuyOrderResponse();

            _stockServiceMock.Setup(stock => stock.CreateBuyOrder(It.IsAny<BuyOrderRequest>()))
                .ReturnsAsync(buyOrderResponse_expected);

            // Act
            var response = await controller.BuyOrder(buyOrderRequest);

            // Assert            
            response.Should().BeOfType<ActionResult<BuyOrderResponse>>();
            var resSubject = response.Result.Should().BeAssignableTo<OkObjectResult>().Subject;
            resSubject.Value.Should().BeEquivalentTo(buyOrderResponse_expected);
        }

        [Fact]
        public async Task CreateBuyOrder_WithInValidData_ToThrowNullArgumentException()
        {
            // Arrange
            var controller = new TradeController(_finnhubService, _stockService, null!, _tradingOptions,null!);
            

            _stockServiceMock.Setup(stock => stock.CreateBuyOrder(null))
                .ThrowsAsync(new ArgumentNullException());

            // Act
            var actual_response = async () =>
            {
                await controller.BuyOrder(null);
            };

            // Assert
            actual_response.Should().ThrowAsync<ArgumentNullException>();
            
        }
    }
}
