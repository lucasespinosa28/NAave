using System.Threading;
using System.Threading.Tasks;
using NAave.Models.PriceOracle;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;

namespace NAave.Controllers.PriceOracle
{
    public partial class PriceOracleService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Web3 web3,
            PriceOracleDeployment priceOracleDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<PriceOracleDeployment>()
                .SendRequestAndWaitForReceiptAsync(priceOracleDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Web3 web3, PriceOracleDeployment priceOracleDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<PriceOracleDeployment>()
                .SendRequestAsync(priceOracleDeployment);
        }

        public static async Task<PriceOracleService> DeployContractAndGetServiceAsync(Web3 web3,
            PriceOracleDeployment priceOracleDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt =
                await DeployContractAndWaitForReceiptAsync(web3, priceOracleDeployment, cancellationTokenSource);
            return new PriceOracleService(web3, receipt.ContractAddress);
        }
    }
}