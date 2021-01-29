using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NAave.Models.PriceOracle
{
    [Function("WETH", "address")]
    public class WethFunction : FunctionMessage
    {
    }
}