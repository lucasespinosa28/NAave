using Nethereum.Contracts.ContractHandlers;
using Nethereum.Web3;

namespace NAave.Controllers.ProtocolDataProvider
{
    public partial class ProtocolDataProviderService
    {
        public ProtocolDataProviderService(Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        protected Web3 Web3 { get; }

        public ContractHandler ContractHandler { get; }
    }
}