using StocksApp.Server.DTOs;
using StocksApp.Server.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace StocksApp.Test
{
    public class StockServiceTest 
    {
        private readonly ITestOutputHelper outputHelper;
        private readonly StockService _stockService;
        public StockServiceTest(ITestOutputHelper test)
        {
            _stockService = new StockService();
            outputHelper = test;
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
            BuyOrderRequest? request = new BuyOrderRequest
            {
                StcokSymbol ="MSFT",
                StockName = "Apple",
                DateAndTimeOfOrder = DateTime.Parse("01-01-2001"),
                Quantity =0 ,
                Price = 100.2
            };

            await Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                // Act
                await _stockService.CreateBuyOrder(request);
            });
        }

        // If you supply all valid values, it should be successful and return an object of BuyOrderResponse type
        // with auto-generated BuyOrderID (guid).


        [Fact]
        public async Task CreateBuyOrder_SupplyValidValues()
        {
            // Arrange 
            BuyOrderRequest? request = new BuyOrderRequest
            {
                StcokSymbol = "MSFT",
                StockName = "Apple",
                DateAndTimeOfOrder = DateTime.Parse("01-01-2001"),
                Quantity = 20,
                Price = 100.2
            };

            // Act
            BuyOrderResponse? buyOrderResponse = await _stockService.CreateBuyOrder(request);
            outputHelper.WriteLine(buyOrderResponse.ToString());
            //Assert
            
            Assert.True(buyOrderResponse.BuyOrderID != Guid.Empty);
            
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
                StcokSymbol = "MSFT",
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
        public async Task CreateSellOrder_SupplyValidValues()
        {
            // Arrange 
            SellOrderRequest? request = new SellOrderRequest
            {
                StcokSymbol = "MSFT",
                StockName = "Apple",
                DateAndTimeOfOrder = DateTime.Parse("01-01-2001"),
                Quantity = 20,
                Price = 100.2
            };

            // Act
            SellOrderResponse? sellOrderResponse = await _stockService.CreateSellOrder(request);
            outputHelper.WriteLine(sellOrderResponse.ToString());
            //Assert

            Assert.True(sellOrderResponse.SellOrderID != Guid.Empty);

        }
        #endregion

        #region GetAllBuyOrders

        [Fact]
        public async Task GetAllBuyOrders_EmptyList()
        {
            // Act
            List<BuyOrderResponse> buyOrders = await _stockService.GetAllBuyOrders();
            //Assert
            Assert.Empty(buyOrders);
        }

        [Fact]

        public async Task GetAllBuyOrders_AddFewBuyOrders()
        {
            // Arrange
            List<BuyOrderRequest> requests = new List<BuyOrderRequest>
            {
                new BuyOrderRequest
                {
                    StcokSymbol = "APL",
                    StockName = "Apple",
                    DateAndTimeOfOrder = DateTime.Parse("03-05-2012"),
                    Quantity = 20,
                    Price = 999.9
                },
                new BuyOrderRequest
                {
                    StcokSymbol = "MSFT",
                    StockName = "Microsoft",
                    DateAndTimeOfOrder = DateTime.Parse("05-09-2021"),
                    Quantity = 30,
                    Price = 20.2
                },
            };
            List<BuyOrderResponse> expectedResponses = new();
            foreach(var request in requests)
            {
                expectedResponses.Add(await _stockService.CreateBuyOrder(request));
            }

            outputHelper.WriteLine("Expected:");
            foreach (var reponse_form_create in expectedResponses)
            {
                outputHelper.WriteLine(reponse_form_create.ToString());
            }


            // Act
            List<BuyOrderResponse> actualResponses = await _stockService.GetAllBuyOrders();
            outputHelper.WriteLine("Actual:");
            foreach (var reponse_from_get in actualResponses)
            {
                outputHelper.WriteLine(reponse_from_get.ToString());
            }

            //Assert
            foreach(var response_to_assert in expectedResponses)
            {
                outputHelper.WriteLine("response_to_assert:");
                outputHelper.WriteLine(response_to_assert.ToString());
                Assert.Contains(response_to_assert, actualResponses);
            }
        }


        #endregion

        #region GetAllSellOrders


        [Fact]
        public async Task GetAllSellOrders_EmptyList()
        {
            // Act
            List<SellOrderResponse> sellOrders = await _stockService.GetAllSellOrders();
            //Assert
            Assert.Empty(sellOrders);
        }

        [Fact]

        public async Task GetAllSellOrders_AddFewBuyOrders()
        {
            // Arrange
            List<SellOrderRequest> requests = new List<SellOrderRequest>
            {
                new SellOrderRequest
                {
                    StcokSymbol = "APL",
                    StockName = "Apple",
                    DateAndTimeOfOrder = DateTime.Parse("03-05-2012"),
                    Quantity = 20,
                    Price = 999.9
                },
                new SellOrderRequest
                {
                    StcokSymbol = "MSFT",
                    StockName = "Microsoft",
                    DateAndTimeOfOrder = DateTime.Parse("05-09-2021"),
                    Quantity = 30,
                    Price = 20.2
                },
            };
            List<SellOrderResponse> expectedResponses = new();
            foreach (var request in requests)
            {
                expectedResponses.Add(await _stockService.CreateSellOrder(request));
            }

            outputHelper.WriteLine("Expected:");
            foreach (var reponse_form_create in expectedResponses)
            {
                outputHelper.WriteLine(reponse_form_create.ToString());
            }


            // Act
            List<SellOrderResponse> actualResponses = await _stockService.GetAllSellOrders();
            outputHelper.WriteLine("Actual:");
            foreach (var reponse_from_get in actualResponses)
            {
                outputHelper.WriteLine(reponse_from_get.ToString());
            }

            //Assert
            foreach (var response_to_assert in expectedResponses)
            {
                outputHelper.WriteLine("response_to_assert:");
                outputHelper.WriteLine(response_to_assert.ToString());
                Assert.Contains(response_to_assert, actualResponses);
            }
        }


        #endregion
    }
}
