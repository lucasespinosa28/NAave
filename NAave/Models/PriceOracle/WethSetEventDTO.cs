using Nethereum.ABI.FunctionEncoding.Attributes;

namespace NAave.Models.PriceOracle
{
    [Event("WethSet")]
    public class WethSetEventDto : IEventDTO
    {
        [Parameter("address", "weth", 1, true)]
        public virtual string Weth { get; set; }
    }
}