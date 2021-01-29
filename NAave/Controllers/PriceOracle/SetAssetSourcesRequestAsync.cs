using System.Collections.Generic;
using System.Threading.Tasks;
using NAave.Models.PriceOracle;

namespace NAave.Controllers.PriceOracle
{
    public partial class PriceOracleService
    {
        public Task<string> SetAssetSourcesRequestAsync(SetAssetSourcesFunction setAssetSourcesFunction)
        {
            return ContractHandler.SendRequestAsync(setAssetSourcesFunction);
        }
    }

    public partial class PriceOracleService
    {
        public Task<string> SetAssetSourcesRequestAsync(List<string> assets, List<string> sources)
        {
            var setAssetSourcesFunction = new SetAssetSourcesFunction {Assets = assets, Sources = sources};

            return ContractHandler.SendRequestAsync(setAssetSourcesFunction);
        }
    }
}