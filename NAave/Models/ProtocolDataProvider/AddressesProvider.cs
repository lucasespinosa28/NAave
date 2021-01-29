using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NAave.Models.ProtocolDataProvider
{
    [Function("ADDRESSES_PROVIDER", "address")]
    public class AddressesProviderFunction : FunctionMessage
    {
    }
}