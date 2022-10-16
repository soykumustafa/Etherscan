using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Soyku.Etherscan.Core.Common;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Soyku.Etherscan.Core.ClientFactory
{
    public class ApiClient : IApiClient
    {
        private readonly HttpClient httpClient;
        private readonly ILogger<ApiClient> logger;

        public string ApiBaseUrl { get; set; }


        public ApiClient(IHttpClientFactory httpClientFactory, ILogger<ApiClient> logger)
        {
            httpClient = httpClientFactory.CreateClient();
            this.logger = logger;
        }

        public async Task<ApiResponse<T>> GetAsync<T>(string url) where T : class
        {
            //httpClient.BaseAddress = new Uri(ApiBaseUrl);
            var response = new ApiResponse<T>();
            try
            {                
                var responseMessage = await httpClient.GetAsync(new Uri(url));

                var resultAsJson = await responseMessage.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<ApiResponse<T>>(resultAsJson);
                logger.LogInformation("ApiClient get data successfully", resultAsJson);
            }
            catch (Exception ex)
            {
                logger.LogError("ApiClient get data error", JsonConvert.SerializeObject(ex.InnerException?.Message ?? ex.Message));
            }

            return response;            
        }

    }
}
