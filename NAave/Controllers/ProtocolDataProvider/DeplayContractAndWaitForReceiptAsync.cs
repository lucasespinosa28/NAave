using System.Threading;
using System.Threading.Tasks;
using NAave.Models.ProtocolDataProvider;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;

namespace NAave.Controllers.ProtocolDataProvider
{
    public partial class ProtocolDataProviderService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Web3 web3,
            DataAbiDeployment dataAbiDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<DataAbiDeployment>()
                .SendRequestAndWaitForReceiptAsync(dataAbiDeployment, cancellationTokenSource);
        }
    }
}