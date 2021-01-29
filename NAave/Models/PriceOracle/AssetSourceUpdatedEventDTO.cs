using Nethereum.ABI.FunctionEncoding.Attributes;

namespace NAave.Models.PriceOracle
{
    [Event("AssetSourceUpdated")]
    public class AssetSourceUpdatedEventDto : IEventDTO
    {
        [Parameter("address", "asset", 1, true)]
        public virtual string Asset { get; set; }

        [Parameter("address", "source", 2, true)]
        public virtual string Source { get; set; }
    }
}