using Nethereum.ABI.FunctionEncoding.Attributes;

namespace NAave.Models.PriceOracle
{
    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDto: IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true)]
        public virtual string PreviousOwner { get; set; }

        [Parameter("address", "newOwner", 2, true)]
        public virtual string NewOwner { get; set; }
    }
}