using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NAave.Models.PriceOracle
{
    [Function("owner", "address")]
    public class OwnerFunction : FunctionMessage
    {
    }
}