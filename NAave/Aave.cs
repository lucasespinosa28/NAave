using NAave.Controllers.PriceOracle;
using NAave.Controllers.ProtocolDataProvider;
using Nethereum.Web3;

namespace NAave
{
    public class Aave
    {
        public Web3 Web  { get; set; }

        public Aave(Web3 web3)
        {
            Web = web3;
        }

        public PriceOracleService PriceOracle(string contractAddress = "0xA50ba011c48153De246E5192C8f9258A2ba79Ca9")
        {
            return new PriceOracleService(Web, contractAddress);
        }
        public ProtocolDataProviderService ProtocolDataProvider(string contractAddress = "0x057835Ad21a177dbdd3090bB1CAE03EaCF78Fc6d")
        {
            return new ProtocolDataProviderService(Web, contractAddress);
        }

    }

}