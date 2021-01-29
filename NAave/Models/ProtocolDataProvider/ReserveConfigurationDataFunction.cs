using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NAave.Models.ProtocolDataProvider
{
    [Function("getReserveConfigurationData", typeof(ReserveConfigurationDataOutputDto))]
    public class ReserveConfigurationDataFunction : FunctionMessage
    {
        [Parameter("address", "asset")] public virtual string Asset { get; set; }
    }

    [FunctionOutput]
    public class ReserveConfigurationDataOutputDto : IFunctionOutputDTO
    {
        [Parameter("uint256", "decimals")] public virtual int Decimals { get; set; }

        [Parameter("uint256", "ltv", 2)] public virtual int Ltv { get; set; }

        [Parameter("uint256", "liquidationThreshold", 3)]
        public virtual int LiquidationThreshold { get; set; }

        [Parameter("uint256", "liquidationBonus", 4)]
        public virtual int LiquidationBonus { get; set; }

        [Parameter("uint256", "reserveFactor", 5)]
        public virtual int ReserveFactor { get; set; }

        [Parameter("bool", "usageAsCollateralEnabled", 6)]
        public virtual bool UsageAsCollateralEnabled { get; set; }

        [Parameter("bool", "borrowingEnabled", 7)]
        public virtual bool BorrowingEnabled { get; set; }

        [Parameter("bool", "stableBorrowRateEnabled", 8)]
        public virtual bool StableBorrowRateEnabled { get; set; }

        [Parameter("bool", "isActive", 9)] public virtual bool IsActive { get; set; }

        [Parameter("bool", "isFrozen", 10)] public virtual bool IsFrozen { get; set; }
    }
}