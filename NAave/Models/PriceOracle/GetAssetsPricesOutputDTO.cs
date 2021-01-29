using System.Collections.Generic;
using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace NAave.Models.PriceOracle
{
    public class GetAssetsPricesOutputDto : GetAssetsPricesOutputDtoBase
    {
    }

    [FunctionOutput]
    public class GetAssetsPricesOutputDtoBase : IFunctionOutputDTO
    {
        [Parameter("uint256[]", "")] public virtual List<BigInteger> ReturnValue1 { get; set; }
    }
}