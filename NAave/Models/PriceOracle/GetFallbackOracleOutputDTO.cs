using Nethereum.ABI.FunctionEncoding.Attributes;

namespace NAave.Models.PriceOracle
{
    public class GetFallbackOracleOutputDto : GetFallbackOracleOutputDtoBase
    {
    }

    [FunctionOutput]
    public class GetFallbackOracleOutputDtoBase : IFunctionOutputDTO
    {
        [Parameter("address", "")] public virtual string ReturnValue1 { get; set; }
    }
}