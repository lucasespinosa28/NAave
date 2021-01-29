using System;
using System.Collections.Generic;
using Xunit;
using Aave;
using Nethereum.Web3;
using System.Threading.Tasks;
using System.Numerics;
using NAave.Controllers.PriceOracle;
using NAave.Models.PriceOracle;

namespace Aave.Test
{
    //    int[] array2 = new int[] { 1, 3, 5, 7, 9 };
    public class PriceOracleTest
    { 
        public List<string> StableCoins = new List<string> { "0x6b175474e89094c44da98b954eedeac495271d0f", "0xdac17f958d2ee523a2206206994597c13d831ec7", };

        public PriceOracleService PriceOracle { get; set; } = new PriceOracleService(new Web3("https://mainnet.infura.io/v3/"), "0xA50ba011c48153De246E5192C8f9258A2ba79Ca9");
        [Fact]
        public async Task OwnerQueryAsyncTest()
        {
            
            var result = await  PriceOracle.OwnerQueryAsync();
            Assert.Equal("0xb9062896ec3a615a4e4444df183f0531a77218ae", result);
        }
        [Fact]
        public async Task WETHQueryAsyncTest()
        {
       
            var result = await PriceOracle.WethQueryAsync();
            Assert.Equal("0xc02aaa39b223fe8d0a0e5c4f27ead9083c756cc2", result);
        }
        [Fact]
        public async Task FallbackOracleQueryAsyncTest()
        {
            var result = await PriceOracle.GetFallbackOracleQueryAsync();
            Assert.Equal("0x5b09e578cfeaa23f1b11127a658855434e4f3e09", result);
        }
        [Fact]
        public async Task AssetPriceQueryAsyncTest()
        {
            var Assets = new GetAssetPriceFunction {Asset = "0x6b175474e89094c44da98b954eedeac495271d0f"};
            var result = await PriceOracle.GetAssetPriceQueryAsync(Assets);
            Assert.True(result > 0);
        }
        [Fact]
        public async Task AssetPricesQueryAsyncTest()
        {
            var result = await PriceOracle.GetAssetsPricesQueryAsync(StableCoins);
            Assert.NotNull(result);
        }
        [Fact]
        public async Task SourceOfAssetQueryAsyncTest()
        {
            var result = await PriceOracle.GetSourceOfAssetQueryAsync("0x6b175474e89094c44da98b954eedeac495271d0f");
            Assert.Equal("0x773616e4d11a78f511299002da57a0a94577f1f4", result);
        }
    }
}
