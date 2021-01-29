using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NAave.Models.ProtocolDataProvider
{
   [Function("getReserveTokensAddresses", typeof(ReserveTokensAddressesOutputDtoBase))]
    public class ReserveTokensAddressesFunction : FunctionMessage
    {
        [Parameter("address", "asset")] public virtual string Asset { get; set; }
    }

    [FunctionOutput]
    public class ReserveTokensAddressesOutputDtoBase : IFunctionOutputDTO
    {
        [Parameter("address", "aTokenAddress")]
        public virtual string ATokenAddress { get; set; }

        [Parameter("address", "stableDebtTokenAddress", 2)]
        public virtual string StableDebtTokenAddress { get; set; }

        [Parameter("address", "variableDebtTokenAddress", 3)]
        public virtual string VariableDebtTokenAddress { get; set; }
    }
}