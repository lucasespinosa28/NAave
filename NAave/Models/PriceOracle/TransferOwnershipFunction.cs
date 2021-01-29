using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NAave.Models.PriceOracle
{
    public class TransferOwnershipFunction : TransferOwnershipFunctionBase
    {
    }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner")] public virtual string NewOwner { get; set; }
    }
}