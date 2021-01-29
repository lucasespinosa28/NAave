using System.Threading;
using System.Threading.Tasks;
using NAave.Models.PriceOracle;
using Nethereum.RPC.Eth.DTOs;

namespace NAave.Controllers.PriceOracle
{
    public partial class PriceOracleService
    {
        public Task<string> SetFallbackOracleRequestAsync(SetFallbackOracleFunction setFallbackOracleFunction)
        {
            return ContractHandler.SendRequestAsync(setFallbackOracleFunction);
        }

        public Task<TransactionReceipt> SetFallbackOracleRequestAndWaitForReceiptAsync(
            SetFallbackOracleFunction setFallbackOracleFunction, CancellationTokenSource cancellationToken = null)
        {
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setFallbackOracleFunction, cancellationToken);
        }

        public Task<string> SetFallbackOracleRequestAsync(string fallbackOracle)
        {
            var setFallbackOracleFunction = new SetFallbackOracleFunction {FallbackOracle = fallbackOracle};

            return ContractHandler.SendRequestAsync(setFallbackOracleFunction);
        }

        public Task<TransactionReceipt> SetFallbackOracleRequestAndWaitForReceiptAsync(string fallbackOracle,
            CancellationTokenSource cancellationToken = null)
        {
            var setFallbackOracleFunction = new SetFallbackOracleFunction {FallbackOracle = fallbackOracle};

            return ContractHandler.SendRequestAndWaitForReceiptAsync(setFallbackOracleFunction, cancellationToken);
        }
    }
}