using System.Threading.Tasks;
using NAave.Models.ProtocolDataProvider;
using Nethereum.Web3;

namespace NAave.Controllers.ProtocolDataProvider
{
    public partial class ProtocolDataProviderService
    {
        public static Task<string> DeployContractAsync(Web3 web3, DataAbiDeployment dataAbiDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<DataAbiDeployment>().SendRequestAsync(dataAbiDeployment);
        }
    }
}