using Nethereum.ABI.FunctionEncoding.Attributes;

namespace NAave.Models.ProtocolDataProvider
{
    public class TokenData : TokenDataBase
    {
    }

    public class TokenDataBase
    {
        [Parameter("string", "symbol")] public virtual string Symbol { get; set; }

        [Parameter("address", "tokenAddress", 2)]
        public virtual string TokenAddress { get; set; }
    }
}