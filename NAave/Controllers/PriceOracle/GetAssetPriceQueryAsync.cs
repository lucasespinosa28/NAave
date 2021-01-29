using System.Numerics;
using System.Threading.Tasks;
using NAave.Models.PriceOracle;
using Nethereum.RPC.Eth.DTOs;

namespace NAave.Controllers.PriceOracle
{
    public partial class PriceOracleService
    {
        public Task<BigInteger> GetAssetPriceQueryAsync(GetAssetPriceFunction getAssetPriceFunction,
            BlockParameter blockParameter = null) =>
            ContractHandler.QueryAsync<GetAssetPriceFunction, BigInteger>(getAssetPriceFunction, blockParameter);
    }
}