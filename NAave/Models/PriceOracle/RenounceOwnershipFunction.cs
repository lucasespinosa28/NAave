using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NAave.Models.PriceOracle
{
    public class RenounceOwnershipFunction : RenounceOwnershipFunctionBase
    {
    }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {
    }
}