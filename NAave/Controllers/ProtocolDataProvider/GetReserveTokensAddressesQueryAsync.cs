using System.Threading.Tasks;
using NAave.Models.ProtocolDataProvider;
using Nethereum.RPC.Eth.DTOs;

namespace NAave.Controllers.ProtocolDataProvider
{
    public partial class ProtocolDataProviderService
    {
        public Task<ReserveTokensAddressesOutputDtoBase> GetReserveTokensAddressesQueryAsync(string asset,
            BlockParameter blockParameter = null) =>
            ContractHandler
                .QueryDeserializingToObjectAsync<ReserveTokensAddressesFunction, ReserveTokensAddressesOutputDtoBase>(
                    new ReserveTokensAddressesFunction { Asset = asset}, blockParameter);
    }
}