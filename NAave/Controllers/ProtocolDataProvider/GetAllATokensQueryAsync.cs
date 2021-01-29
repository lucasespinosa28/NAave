using System.Threading.Tasks;
using NAave.Models.ProtocolDataProvider;
using Nethereum.RPC.Eth.DTOs;

namespace NAave.Controllers.ProtocolDataProvider
{
    public partial class ProtocolDataProviderService
    {
        public Task<AllATokensOutputDto> GetAllATokensQueryAsync(AllATokensFunction allATokensFunction = null, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<AllATokensFunction, AllATokensOutputDto>(allATokensFunction, blockParameter);
        }
    }
}