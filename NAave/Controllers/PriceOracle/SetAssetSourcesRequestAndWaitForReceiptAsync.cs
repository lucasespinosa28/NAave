using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using NAave.Models.PriceOracle;
using Nethereum.RPC.Eth.DTOs;

namespace NAave.Controllers.PriceOracle
{
    public partial class PriceOracleService
    {
        public Task<TransactionReceipt> SetAssetSourcesRequestAndWaitForReceiptAsync(
            SetAssetSourcesFunction setAssetSourcesFunction, CancellationTokenSource cancellationToken = null)
        {
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setAssetSourcesFunction, cancellationToken);
        }
    }

    public partial class PriceOracleService
    {
        public Task<TransactionReceipt> SetAssetSourcesRequestAndWaitForReceiptAsync(List<string> assets,
            List<string> sources, CancellationTokenSource cancellationToken = null)
        {
            var setAssetSourcesFunction = new SetAssetSourcesFunction {Assets = assets, Sources = sources};

            return ContractHandler.SendRequestAndWaitForReceiptAsync(setAssetSourcesFunction, cancellationToken);
        }
    }
}