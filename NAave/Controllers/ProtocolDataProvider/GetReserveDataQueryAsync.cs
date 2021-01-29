using System.Threading.Tasks;
using NAave.Models.ProtocolDataProvider;
using Nethereum.RPC.Eth.DTOs;

namespace NAave.Controllers.ProtocolDataProvider
{
    public partial class ProtocolDataProviderService
    {
        public Task<ReserveDataOutputDto> GetReserveDataQueryAsync(string asset, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<ReserveDataFunction, ReserveDataOutputDto>(
                new ReserveDataFunction { Asset = asset }, blockParameter);
        }
    }
}