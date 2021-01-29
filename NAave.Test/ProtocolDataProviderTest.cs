using System;
using System.Collections.Generic;
using Xunit;
using Aave;
using Nethereum.Web3;
using System.Threading.Tasks;
using System.Numerics;
using NAave.Controllers.ProtocolDataProvider;
using NAave.Models.ProtocolDataProvider;

namespace Aave.Test
{
    public class ProtocolDataProviderTest
    { 
        public List<string> StableCoins = new List<string> { "0x6b175474e89094c44da98b954eedeac495271d0f", "0xdac17f958d2ee523a2206206994597c13d831ec7", };

        public ProtocolDataProviderService ProtocolData { get; set; } = new ProtocolDataProviderService(new Web3("https://mainnet.infura.io/v3/"), "0x057835Ad21a177dbdd3090bB1CAE03EaCF78Fc6d");

        [Fact]
        public async Task AddressesProviderQueryAsyncTest()
        {

            var result = await ProtocolData.AddressesProviderQueryAsync();
            Assert.Equal("0xb53c1a33016b2dc2ff3653530bff1848a515c8c5", result);
        }
        [Fact]
        public async Task AllATokensQueryAsyncTest()
        {
            var result = await ProtocolData.GetAllATokensQueryAsync();
            Assert.NotNull(result.ATokens[0].Symbol);
            Assert.NotNull(result.ATokens[0].TokenAddress);
        }
        [Fact]
        public async Task AllReservesTokensQueryAsyncTest()
        {
            var result = await ProtocolData.GetAllReservesTokensQueryAsync();
            Assert.NotNull(result.ReserveTokens);
            Assert.NotNull(result.ReserveTokens[0].Symbol);
            Assert.NotNull(result.ReserveTokens[0].TokenAddress);
        }
        [Fact]
        public async Task ReserveConfigurationDataQueryTest()
        {
            var result = await ProtocolData.GetReserveConfigurationDataQueryAsync("0x6b175474e89094c44da98b954eedeac495271d0f");
            Assert.True(result.BorrowingEnabled);
            Assert.True(result.IsActive);
            Assert.False(result.IsFrozen);
            Assert.True(result.StableBorrowRateEnabled);
            Assert.True(result.UsageAsCollateralEnabled);
            Assert.True(result.Decimals > 0);
            Assert.True(result.LiquidationBonus > 0);
            Assert.True(result.LiquidationThreshold > 0);
            Assert.True(result.ReserveFactor > 0);
            Assert.True(result.Ltv > 0);
        }
        [Fact]
        public async Task ReserveDataQueryAsyncTest()
        {
            var result = await ProtocolData.GetReserveDataQueryAsync("0x6b175474e89094c44da98b954eedeac495271d0f");
            Assert.True(result.AvailableLiquidity > 0);
            Assert.True(result.TotalStableDebt > 0);
            Assert.True(result.TotalVariableDebt > 0);
            Assert.True(result.LiquidityRate > 0);
            Assert.True(result.VariableBorrowRate > 0);
            Assert.True(result.StableBorrowRate > 0);
            Assert.True(result.AverageStableBorrowRate > 0);
            Assert.True(result.LiquidityIndex > 0);
            Assert.True(result.VariableBorrowIndex > 0);
            Assert.True(result.LastUpdateTimestamp > 0);
        }
        [Fact]
        public async Task ReserveTokensAddressesQueryAsyncStringTest()
        {
            var result = await ProtocolData.GetReserveTokensAddressesQueryAsync("0x6b175474e89094c44da98b954eedeac495271d0f");
           Assert.True(result.ATokenAddress.Length > 0);
           Assert.True(result.StableDebtTokenAddress.Length > 0);
           Assert.True(result.VariableDebtTokenAddress.Length > 0);
        }
        [Fact]
        public async Task UserReserveDataQueryAsyncTest()
        {
            var result = await ProtocolData.GetUserReserveDataQueryAsync("0x6b175474e89094c44da98b954eedeac495271d0f", "0x850e70b110012cffa946464a4e4471f362d9457d");
            Assert.True(result.CurrentATokenBalance > 0);
            Assert.True(result.CurrentStableDebt == 0);
            Assert.True(result.CurrentVariableDebt > 0);
            Assert.True(result.LiquidityRate > 0);
            Assert.True(result.PrincipalStableDebt == 0);
            Assert.True(result.ScaledVariableDebt > 0);
            Assert.True(result.StableBorrowRate == 0);
            Assert.True(result.UsageAsCollateralEnabled);
            Assert.True(result.StableRateLastUpdated == 0);
        }
    }
}
