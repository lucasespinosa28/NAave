using System.Threading.Tasks;
using NAave.Models.ProtocolDataProvider;
using Nethereum.RPC.Eth.DTOs;

namespace NAave.Controllers.ProtocolDataProvider
{
    public partial class ProtocolDataProviderService
    {
       public Task<string> AddressesProviderQueryAsync(AddressesProviderFunction addressesProviderFunction = null ,BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AddressesProviderFunction, string>(addressesProviderFunction, blockParameter);
        }
    }
}