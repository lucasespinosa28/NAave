using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace NAave.Models.PriceOracle
{
    public class GetAssetPriceOutputDto : GetAssetPriceOutputDtoBase
    {
    }

    [FunctionOutput]
    public class GetAssetPriceOutputDtoBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "")] public virtual BigInteger ReturnValue1 { get; set; }
    }
}