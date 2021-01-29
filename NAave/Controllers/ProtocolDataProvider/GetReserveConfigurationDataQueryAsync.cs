using System.Threading.Tasks;
using NAave.Models.ProtocolDataProvider;
using Nethereum.RPC.Eth.DTOs;

namespace NAave.Controllers.ProtocolDataProvider
{
    public partial class ProtocolDataProviderService
    {
        public Task<ReserveConfigurationDataOutputDto> GetReserveConfigurationDataQueryAsync(string asset,
            BlockParameter blockParameter = null) =>
            ContractHandler
                .QueryDeserializingToObjectAsync<ReserveConfigurationDataFunction, ReserveConfigurationDataOutputDto>(
                    new ReserveConfigurationDataFunction { Asset = asset }, blockParameter);
    }
}