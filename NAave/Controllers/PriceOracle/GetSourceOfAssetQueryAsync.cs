using System.Threading.Tasks;
using NAave.Models.PriceOracle;
using Nethereum.RPC.Eth.DTOs;

namespace NAave.Controllers.PriceOracle
{
    public partial class PriceOracleService
    {
        public Task<string> GetSourceOfAssetQueryAsync(string asset, BlockParameter blockParameter = null) =>
            ContractHandler.QueryAsync<GetSourceOfAssetFunction, string>(new GetSourceOfAssetFunction { Asset = asset },
                blockParameter);
    }
}