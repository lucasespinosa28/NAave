using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NAave.Models.ProtocolDataProvider
{
    public class ReserveDataFunction : ReserveDataFunctionBase
    {
    }

    [Function("getReserveData", typeof(ReserveDataOutputDto))]
    public class ReserveDataFunctionBase : FunctionMessage
    {
        [Parameter("address", "asset")] public virtual string Asset { get; set; }
    }

    public class ReserveDataOutputDto : ReserveDataOutputDtoBase
    {
    }

    [FunctionOutput]
    public class ReserveDataOutputDtoBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "availableLiquidity")]
        public virtual BigInteger AvailableLiquidity { get; set; }

        [Parameter("uint256", "totalStableDebt", 2)]
        public virtual BigInteger TotalStableDebt { get; set; }

        [Parameter("uint256", "totalVariableDebt", 3)]
        public virtual BigInteger TotalVariableDebt { get; set; }

        [Parameter("uint256", "liquidityRate", 4)]
        public virtual BigInteger LiquidityRate { get; set; }

        [Parameter("uint256", "variableBorrowRate", 5)]
        public virtual BigInteger VariableBorrowRate { get; set; }

        [Parameter("uint256", "stableBorrowRate", 6)]
        public virtual BigInteger StableBorrowRate { get; set; }

        [Parameter("uint256", "averageStableBorrowRate", 7)]
        public virtual BigInteger AverageStableBorrowRate { get; set; }

        [Parameter("uint256", "liquidityIndex", 8)]
        public virtual BigInteger LiquidityIndex { get; set; }

        [Parameter("uint256", "variableBorrowIndex", 9)]
        public virtual BigInteger VariableBorrowIndex { get; set; }

        [Parameter("uint40", "lastUpdateTimestamp", 10)]
        public virtual ulong LastUpdateTimestamp { get; set; }
    }
}