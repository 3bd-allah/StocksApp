using FluentAssertions;
using Microsoft.AspNetCore.Http;
using StocksApp.Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Json;
using System.Text;

namespace StocksApp.Test.IntegrationTests
{
    public class TradeControllerIntegrationTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _client;
        private readonly ITestOutputHelper _outputHelper; 
        public TradeControllerIntegrationTest(CustomWebApplicationFactory factory, ITestOutputHelper testOutputHelper)
        {
            _outputHelper = testOutputHelper;
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task CompanyProfile_ToBeSuccess()
        {
            HttpResponseMessage response = await _client.GetAsync("/api/trade/orders");
            response.IsSuccessStatusCode.Should().BeTrue();

            StockTradeDTO? responseBody = await response.Content.ReadFromJsonAsync<StockTradeDTO>();
            
            responseBody.Should().BeOfType<StockTradeDTO>();
        }
    }
}
