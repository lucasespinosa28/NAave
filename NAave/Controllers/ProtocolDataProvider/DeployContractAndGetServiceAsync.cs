using System.Threading;
using System.Threading.Tasks;
using NAave.Models.ProtocolDataProvider;
using Nethereum.Web3;

namespace NAave.Controllers.ProtocolDataProvider
{
    public partial class ProtocolDataProviderService
    {
        public static async Task<ProtocolDataProviderService> DeployContractAndGetServiceAsync(Web3 web3,
            DataAbiDeployment dataAbiDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, dataAbiDeployment, cancellationTokenSource);
            return new ProtocolDataProviderService(web3, receipt.ContractAddress);
        }
    }
}