using System.Threading.Tasks;
using NAave.Models.ProtocolDataProvider;
using Nethereum.RPC.Eth.DTOs;

namespace NAave.Controllers.ProtocolDataProvider
{
    public partial class ProtocolDataProviderService
    {
       public Task<AllReservesTokensOutputDto> GetAllReservesTokensQueryAsync(BlockParameter blockParameter = null) =>
           ContractHandler
               .QueryDeserializingToObjectAsync<AllReservesTokensFunction, AllReservesTokensOutputDto>(null, blockParameter);
    }
}