using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NAave.Models.PriceOracle
{
    public class GetSourceOfAssetFunction : GetSourceOfAssetFunctionBase
    {
    }

    [Function("getSourceOfAsset", "address")]
    public class GetSourceOfAssetFunctionBase : FunctionMessage
    {
        [Parameter("address", "asset")] public virtual string Asset { get; set; }
    }
}