
using Newtonsoft.Json;
using Soyku.Etherscan.Core.Common;
using Soyku.Etherscan.Core.Domain.Ropsten;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Soyku.Etherscan.UI.Services
{
    public class RopstenService
    {
        private readonly string apiUrl= "https://localhost:44364/Ropsten";
        
        public async Task<IEnumerable<Employee>> GetAllEmployees(string parameters)
        {
            using (HttpClient client = new HttpClient())
            {
                var requestUrl = $"{apiUrl}?{parameters}";
                using (HttpResponseMessage res = await client.GetAsync(requestUrl))
                {
                    using (HttpContent content = res.Content)
                    {
                        var jsonResult = await content.ReadAsStringAsync();
                        var response = JsonConvert.DeserializeObject<ApiResponse<List<Employee>>>(jsonResult);

                        return response.Result;
                    }
                }
            }
        }

    }
}
