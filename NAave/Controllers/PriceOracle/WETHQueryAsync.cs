using System.Threading.Tasks;
using NAave.Models.PriceOracle;
using Nethereum.RPC.Eth.DTOs;

namespace NAave.Controllers.PriceOracle
{
    public partial class PriceOracleService
    {
        public Task<string> WethQueryAsync(WethFunction wethFunction = null, BlockParameter blockParameter = null) => ContractHandler.QueryAsync<WethFunction, string>(wethFunction, blockParameter);
        
    }
}