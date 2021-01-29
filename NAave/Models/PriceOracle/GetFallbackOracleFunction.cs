using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NAave.Models.PriceOracle
{
    public class GetFallbackOracleFunction : GetFallbackOracleFunctionBase
    {
    }

    [Function("getFallbackOracle", "address")]
    public class GetFallbackOracleFunctionBase : FunctionMessage
    {
    }
}