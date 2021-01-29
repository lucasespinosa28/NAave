using System.Collections.Generic;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NAave.Models.PriceOracle
{
    public class SetAssetSourcesFunction : SetAssetSourcesFunctionBase
    {
    }

    [Function("setAssetSources")]
    public class SetAssetSourcesFunctionBase : FunctionMessage
    {
        [Parameter("address[]", "assets")] public virtual List<string> Assets { get; set; }

        [Parameter("address[]", "sources", 2)] public virtual List<string> Sources { get; set; }
    }
}