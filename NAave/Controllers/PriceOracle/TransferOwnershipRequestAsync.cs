using System.Threading;
using System.Threading.Tasks;
using NAave.Models.PriceOracle;
using Nethereum.RPC.Eth.DTOs;

namespace NAave.Controllers.PriceOracle
{
    public partial class PriceOracleService
    {
        public Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction)
        {
            return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }
        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(
            TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
            return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }
        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner,
            CancellationTokenSource cancellationToken = null) =>
           ContractHandler.SendRequestAndWaitForReceiptAsync(new TransferOwnershipFunction { NewOwner = newOwner }, cancellationToken);
    }
}