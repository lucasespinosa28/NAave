using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NAave.Models.ProtocolDataProvider
{
    public class UserReserveDataFunction : UserReserveDataFunctionBase
    {
    }

    [Function("getUserReserveData", typeof(UserReserveDataOutputDto))]
    public class UserReserveDataFunctionBase : FunctionMessage
    {
        [Parameter("address", "asset")] public virtual string Asset { get; set; }

        [Parameter("address", "user", 2)] public virtual string User { get; set; }
    }
    
    [FunctionOutput]
    public class UserReserveDataOutputDto : IFunctionOutputDTO
    {
        [Parameter("uint256", "currentATokenBalance")]
        public virtual BigInteger CurrentATokenBalance { get; set; }

        [Parameter("uint256", "currentStableDebt", 2)]
        public virtual BigInteger CurrentStableDebt { get; set; }

        [Parameter("uint256", "currentVariableDebt", 3)]
        public virtual BigInteger CurrentVariableDebt { get; set; }

        [Parameter("uint256", "principalStableDebt", 4)]
        public virtual BigInteger PrincipalStableDebt { get; set; }

        [Parameter("uint256", "scaledVariableDebt", 5)]
        public virtual BigInteger ScaledVariableDebt { get; set; }

        [Parameter("uint256", "stableBorrowRate", 6)]
        public virtual BigInteger StableBorrowRate { get; set; }

        [Parameter("uint256", "liquidityRate", 7)]
        public virtual BigInteger LiquidityRate { get; set; }

        [Parameter("uint40", "stableRateLastUpdated", 8)]
        public virtual ulong StableRateLastUpdated { get; set; }

        [Parameter("bool", "usageAsCollateralEnabled", 9)]
        public virtual bool UsageAsCollateralEnabled { get; set; }
    }
}