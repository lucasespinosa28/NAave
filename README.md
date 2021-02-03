# NAave
Library to accesses Aave price feed oracle using Nethereum
# NChainlink [![NuGet](https://img.shields.io/nuget/v/NChainlink)](https://www.nuget.org/packages/NChainlink/) ![License](https://img.shields.io/github/license/lucasespinosa28/NChainlink)

NChainlink a library made for Nethereum to help work with chainlink smart contract 

## How to use NChainlink 
#### Basic example
```C#
using System;
using NAave;
using Nethereum.Web3;
using System.Threading.Tasks;

//Ethereum endpoint URL.
var web3 = new Web3("https://mainnet.infura.io/v3/<KEY>");

//Pass web3 to Aave to access Ethereum
var aave = new Aave(web3);

//Aave Protocol data 
var protocolDataProvider = aave.ProtocolDataProvider();

//Aave oracle  
var PriceOracle = aave.PriceOracle();

//get list all reserves tokens in Aave
var AllTokens = await protocolDataProvider.GetAllReservesTokensQueryAsync();

foreach (var token in AllTokens.ReserveTokens)
{
    // Get the last price
    var price = await PriceOracle.GetAssetPriceQueryAsync(token.TokenAddress);
    // Get Aave information about the token
    var data = await protocolDataProvider.GetReserveDataQueryAsync(token.TokenAddress);
    string text = $"Synbol            - {token.Symbol}\n" +
                  $"Price             - {price}\n" +
                  $"Deposit APY       - {data.LiquidityRate}\n" +
                  $"Varible Barrow APR- {data.VariableBorrowRate}\n" +
                  $"Stable Barrow APR - {data.StableBorrowRate}\n";
    Console.WriteLine(text);
}
```
