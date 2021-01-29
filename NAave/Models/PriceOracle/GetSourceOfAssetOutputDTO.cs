using Nethereum.ABI.FunctionEncoding.Attributes;

namespace NAave.Models.PriceOracle
{
    public class GetSourceOfAssetOutputDto : GetSourceOfAssetOutputDtoBase
    {
    }

    [FunctionOutput]
    public class GetSourceOfAssetOutputDtoBase : IFunctionOutputDTO
    {
        [Parameter("address", "")] public virtual string ReturnValue1 { get; set; }
    }
}