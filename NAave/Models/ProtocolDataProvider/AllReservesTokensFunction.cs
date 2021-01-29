using System.Collections.Generic;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NAave.Models.ProtocolDataProvider
{
    public class AllReservesTokensFunction : AllReservesTokensFunctionBase
    {
    }

    [Function("getAllReservesTokens", typeof(AllReservesTokensOutputDto))]
    public class AllReservesTokensFunctionBase : FunctionMessage
    {
    }

    public class AllReservesTokensOutputDto : AllReservesTokensOutputDtoBase
    {
    }

    [FunctionOutput]
    public class AllReservesTokensOutputDtoBase : IFunctionOutputDTO
    {
        [Parameter("tuple[]", "")] public virtual List<TokenData> ReserveTokens { get; set; }
    }
}