using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NAave.Models.PriceOracle
{
    public class SetFallbackOracleFunction : SetFallbackOracleFunctionBase
    {
    }

    [Function("setFallbackOracle")]
    public class SetFallbackOracleFunctionBase : FunctionMessage
    {
        [Parameter("address", "fallbackOracle")]
        public virtual string FallbackOracle { get; set; }
    }
}