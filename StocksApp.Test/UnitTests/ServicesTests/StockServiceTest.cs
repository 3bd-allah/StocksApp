using AutoFixture;
using FluentAssertions;
using StocksApp.Server.DTOs;
using StocksApp.Server.IRepository;
using StocksApp.Server.Services;
using Moq;
using StocksApp.Server.Entities;
using Microsoft.EntityFrameworkCore.Query.Internal;
namespace StocksApp.Test.UnitTests.ServicesTests
{
    public class StockServiceTest 
    {
        private readonly ITestOutputHelper outputHelper;
        private readonly StockService _stockService;
        private readonly IStockRepository stockRepository;
        private readonly Mock<IStockRepository> stockRepositoryMock;
        private readonly IFixture autoFixture;
        public StockServiceTest(ITestOutputHelper test)
        {
            stockRepositoryMock = new Mock<IStockRepository>();
            stockRepository = stockRepositoryMock.Object;
            _stockService = new StockService(stockRepository);
            outputHelper = test;
            autoFixture = new Fixture();
        }

        #region CreateBuyOrder
        // When you supply BuyOrderRequest as null, it should throw ArgumentNullException.
        [Fact]
        public async Task CreateBuyOrder_NullRequest()
        {
            // Arrange 
            BuyOrderRequest? request = null;

            await Assert.ThrowsAsync<ArgumentNullException>( async () =>
            {
                // Act
                await _stockService.CreateBuyOrder(request);
            });
        }

        // When you supply buyOrderQuantity as 0 (as per the specification, minimum is 1),
        // it should throw ArgumentException.

        [Fact]
        public async Task CreateBuyOrder_ZeroBuyOrderQuantity()
        {
            // Arrange 
            BuyOrderRequest? req = autoFixture.Build<BuyOrderRequest>()
                .With(temp => temp.Quantity, Convert.ToUInt32(0))
                .Create();
            
            // Act
            Func<Task<BuyOrderResponse>> actual = async () => await _stockService.CreateBuyOrder(req);

            // Assert
            await actual.Should().ThrowAsync<ArgumentException>();
        }

        // If you supply all valid values, it should be successful and return an object of BuyOrderResponse type
        // with auto-generated BuyOrderID (guid).


        [Fact]
        public async Task CreateBuyOrder_SupplyValidValues()
        {
            // Arrange 
            
            var buyOrderRequest = autoFixture.Build<BuyOrderRequest>()
                .With(temp => temp.DateAndTimeOfOrder, DateTime.Parse("01-01-2001"))
                .Create();
           
            var buyOrder = buyOrderRequest.ToBuyOrder();
            var buyOrderResponse_expected = buyOrder.ToBuyOrderResponse();

            BuyOrderResponse buyOrder_from_add_expected = buyOrder.ToBuyOrderResponse();

            stockRepositoryMock.Setup(repo => repo.AddBuyOrder(It.IsAny<BuyOrder>()))
                .ReturnsAsync(buyOrder);

            // Act
            BuyOrderResponse? buyOrderResponse_actual = await _stockService.CreateBuyOrder(buyOrderRequest);
            outputHelper.WriteLine($"Actual:\n{buyOrderResponse_actual.ToString()}");

            buyOrder_from_add_expected.BuyOrderID = buyOrderResponse_actual.BuyOrderID;
            outputHelper.WriteLine($"Expected:\n{buyOrder_from_add_expected.ToString()}");


            //Assert
            buyOrderResponse_actual.Should().Be(buyOrder_from_add_expected);
            
        }

        #endregion

        #region CreateSellOrder

        [Fact]
        public async Task CreateSellOrder_NullRequest()
        {
            // Arrange
            SellOrderRequest? request = null;

            //Assert
            await Assert.ThrowsAsync<ArgumentNullException>(async () =>
            {
                await _stockService.CreateSellOrder(request);
            });
        }

        [Fact]
        public async Task CreateSellOrder_ZeroSellOrderQuantity()
        {
            // Arrange 
            SellOrderRequest? request = new SellOrderRequest
            {
                StockSymbol = "MSFT",
                StockName = "Apple",
                DateAndTimeOfOrder = DateTime.Parse("01-01-2001"),
                Quantity = 0,
                Price = 100.2
            };

            await Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                // Act
                await _stockService.CreateSellOrder(request);
            });
        }


        [Fact]
        public async Task CreateSellOrder_SupplyValidValues_ToBeSuccessful()
        {
            // Arrange 
            SellOrderRequest? sellOrderRequest = new SellOrderRequest
            {
                StockSymbol = "MSFT",
                StockName = "Apple",
                DateAndTimeOfOrder = DateTime.Parse("01-01-2001"),
                Quantity = 20,
                Price = 100.2
            };

            SellOrder sellOrder = sellOrderRequest.ToSellOrder();
            SellOrderResponse sellOrder_from_add_expected = sellOrder.ToSellOrderResponse();

            stockRepositoryMock.Setup(repo => repo.AddSellOrder(It.IsAny<SellOrder>()))
                .ReturnsAsync(sellOrder);
           

            // Act
            SellOrderResponse? sellOrderResponse_actual = await _stockService.CreateSellOrder(sellOrderRequest);
            outputHelper.WriteLine("Actual:");
            outputHelper.WriteLine(sellOrderResponse_actual.ToString());
            sellOrder_from_add_expected.SellOrderID = sellOrderResponse_actual.SellOrderID;

            outputHelper.WriteLine("Expected:");
            outputHelper.WriteLine(sellOrder_from_add_expected.ToString());

            //Assert
            sellOrderResponse_actual?.Should().Be(sellOrder_from_add_expected);

        }
        #endregion

        #region GetAllBuyOrders

        [Fact]
        public async Task GetAllBuyOrders_EmptyList()
        {
            stockRepositoryMock.Setup(repo => repo.GetAllBuyOrders())
                .ReturnsAsync(new List<BuyOrder>());
            // Act
            List<BuyOrderResponse> buyOrders_actual = await _stockService.GetAllBuyOrders();
            //Assert
            buyOrders_actual.Should().BeEmpty();

        }

        [Fact]
        public async Task GetAllBuyOrders_WithFewBuyOrders_ToBeSuccessful()
        {
            // Arrange
            List<BuyOrderRequest> buyOrder_requests = new List<BuyOrderRequest>
            {
                autoFixture.Build<BuyOrderRequest>()
                .With(temp => temp.DateAndTimeOfOrder, DateTime.Parse("03-05-2012"))
                .Create(),

                 autoFixture.Build<BuyOrderRequest>()
                .With(temp => temp.DateAndTimeOfOrder, DateTime.Parse("05-09-2021"))
                .Create(),
            };

            List<BuyOrder> buyOrders_expected = buyOrder_requests
                .Select(bor => bor.ToBuyOrder())
                .ToList();

           

            stockRepositoryMock.Setup(repo => repo.GetAllBuyOrders())
                .ReturnsAsync(buyOrders_expected);

            // Act
            List<BuyOrderResponse> actualResponses = await _stockService.GetAllBuyOrders();
            outputHelper.WriteLine("Actual:");

            var expectedResponses = buyOrders_expected.Select(bor => bor.ToBuyOrderResponse()).ToList();

            for (int i = 0; i < actualResponses.Count; i++)
            {
                expectedResponses[i].BuyOrderID = actualResponses[i].BuyOrderID;
            }

            foreach (var reponse_from_get in actualResponses)
            {
                outputHelper.WriteLine(reponse_from_get.ToString());
            }

            outputHelper.WriteLine("Expected:");
            foreach (var buyOrder_expected in buyOrders_expected)
            {
                outputHelper.WriteLine(buyOrder_expected.ToString()!);
            }


            //Assert
           actualResponses.Should().BeEquivalentTo(expectedResponses);
        }


        #endregion

        #region GetAllSellOrders


        [Fact]
        public async Task GetAllSellOrders_EmptyList()
        {
            stockRepositoryMock
                .Setup(repo => repo.GetAllSellOrders())
                .ReturnsAsync(new List<SellOrder>());
            // Act
            List<SellOrderResponse> sellOrders_actual = await _stockService.GetAllSellOrders();
            //Assert
            //Assert.Empty(sellOrders_actual);
            sellOrders_actual.Should().BeEmpty();
        }

        [Fact]

        public async Task GetAllSellOrders_FewSellOrders_ToBeSuccessful()
        {
            // Arrange
            List<SellOrder> sellOrders = new List<SellOrder>
            {
                autoFixture.Build<SellOrder>()
                .With(temp => temp.DateAndTimeOfOrder, DateTime.Parse("03-05-2012"))
                .Create(),
                 autoFixture.Build<SellOrder>()
                .With(temp => temp.DateAndTimeOfOrder, DateTime.Parse("05-09-2021"))
                .Create(),
            };

            stockRepositoryMock
                .Setup(repo => repo.GetAllSellOrders())
                .ReturnsAsync(sellOrders);

            List<SellOrderResponse> expectedResponses = sellOrders.Select(so => so.ToSellOrderResponse()).ToList();

            outputHelper.WriteLine("Expected:");
            foreach (var response_expected in expectedResponses)
            {
                outputHelper.WriteLine(response_expected.ToString());
            }


            // Act
            List<SellOrderResponse> actualResponses = await _stockService.GetAllSellOrders();
            outputHelper.WriteLine("Actual:");
            foreach (var response_from_get in actualResponses)
            {
                outputHelper.WriteLine(response_from_get.ToString());
            }

            //Assert
            actualResponses.Should().BeEquivalentTo(expectedResponses);
        }


        #endregion
    }
}
