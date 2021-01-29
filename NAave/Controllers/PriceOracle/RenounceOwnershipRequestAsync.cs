using System.Threading;
using System.Threading.Tasks;
using NAave.Models.PriceOracle;
using Nethereum.RPC.Eth.DTOs;

namespace NAave.Controllers.PriceOracle
{
    public partial class PriceOracleService
    {
        public Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction)
        {
            return ContractHandler.SendRequestAsync(renounceOwnershipFunction);
        }
        public Task<string> RenounceOwnershipRequestAsync()
        {
            return ContractHandler.SendRequestAsync<RenounceOwnershipFunction>();
        }
    }

}