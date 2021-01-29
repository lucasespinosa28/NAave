using System.Threading.Tasks;
using NAave.Models.PriceOracle;
using Nethereum.RPC.Eth.DTOs;

namespace NAave.Controllers.PriceOracle
{
    public partial class PriceOracleService
    {
        public Task<string> GetFallbackOracleQueryAsync(BlockParameter blockParameter = null) => ContractHandler.QueryAsync<GetFallbackOracleFunction, string>(null, blockParameter);
    }
}