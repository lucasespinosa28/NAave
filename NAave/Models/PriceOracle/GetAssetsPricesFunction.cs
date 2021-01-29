using System.Collections.Generic;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NAave.Models.PriceOracle
{
    public class GetAssetsPricesFunction : GetAssetsPricesFunctionBase
    {
    }
    [Function("getAssetsPrices", "uint256[]")]
    public class GetAssetsPricesFunctionBase : FunctionMessage
    {
        [Parameter("address[]", "assets")] public virtual List<string> Assets { get; set; }
    }
}