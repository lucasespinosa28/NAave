using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NAave.Models.PriceOracle
{
    public class GetAssetPriceFunction : GetAssetPriceFunctionBase
    {
    }

    [Function("getAssetPrice", "uint256")]
    public class GetAssetPriceFunctionBase : FunctionMessage
    {
        [Parameter("address", "asset")] public virtual string Asset { get; set; }
    }
}