using System.Threading.Tasks;
using NAave.Models.ProtocolDataProvider;
using Nethereum.RPC.Eth.DTOs;

namespace NAave.Controllers.ProtocolDataProvider
{
    public partial class ProtocolDataProviderService
    {
       public Task<UserReserveDataOutputDto> GetUserReserveDataQueryAsync(string asset, string user,
            BlockParameter blockParameter = null)
        {
            var getUserReserveDataFunction = new UserReserveDataFunction {Asset = asset, User = user};

            return ContractHandler.QueryDeserializingToObjectAsync<UserReserveDataFunction, UserReserveDataOutputDto>(
                getUserReserveDataFunction, blockParameter);
        }
    }
}