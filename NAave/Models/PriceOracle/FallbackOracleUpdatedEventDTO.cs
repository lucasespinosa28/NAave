using Nethereum.ABI.FunctionEncoding.Attributes;

namespace NAave.Models.PriceOracle
{
   [Event("FallbackOracleUpdated")]
    public class FallbackOracleUpdatedEventDtoBase : IEventDTO
    {
        [Parameter("address", "fallbackOracle", 1, true)]
        public virtual string FallbackOracle { get; set; }
    }
}