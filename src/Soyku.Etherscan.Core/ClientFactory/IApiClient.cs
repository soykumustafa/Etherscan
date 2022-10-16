using Soyku.Etherscan.Core.Common;
using System.Threading.Tasks;

namespace Soyku.Etherscan.Core.ClientFactory
{
    public interface IApiClient
    {
        Task<ApiResponse<T>> GetAsync<T>(string url) where T:class;
        string ApiBaseUrl { get; set; }
    }
}
