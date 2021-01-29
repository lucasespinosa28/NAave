using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using NAave.Models.PriceOracle;
using Nethereum.RPC.Eth.DTOs;

namespace NAave.Controllers.PriceOracle
{
    public partial class PriceOracleService
    {
        public Task<List<BigInteger>> GetAssetsPricesQueryAsync(List<string> assets,
            BlockParameter blockParameter = null) =>
            ContractHandler.
                QueryAsync<GetAssetsPricesFunction, List<BigInteger>>
                    (new GetAssetsPricesFunction { Assets = assets }, blockParameter);
    }
}