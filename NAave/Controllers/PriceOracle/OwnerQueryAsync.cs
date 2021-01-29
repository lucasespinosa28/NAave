using System.Threading.Tasks;
using NAave.Models.PriceOracle;
using Nethereum.RPC.Eth.DTOs;

namespace NAave.Controllers.PriceOracle
{
    public partial class PriceOracleService
    {
        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction = null,BlockParameter blockParameter = null) => ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        
    }
}