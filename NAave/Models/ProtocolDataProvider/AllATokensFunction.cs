using System.Collections.Generic;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NAave.Models.ProtocolDataProvider
{
    [Function("getAllATokens", typeof(AllATokensOutputDto))]
    public class AllATokensFunction : FunctionMessage
    {
    }

    [FunctionOutput]
    public class AllATokensOutputDto : IFunctionOutputDTO
    {
        [Parameter("tuple[]", "")] public virtual List<TokenData> ATokens { get; set; }
    }
}