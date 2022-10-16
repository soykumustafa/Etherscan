using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Soyku.Etherscan.Core.ClientFactory;
using Soyku.Etherscan.Core.Domain.Ropsten;
using Soyku.Etherscan.Core.ResponseRequestModel.Ropsten;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Soyku.Etherscan.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RopstenController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<RopstenController> logger;
        private readonly IApiClient apiClient;

        public RopstenController(ILogger<RopstenController> logger, IApiClient apiClient, IConfiguration configuration)
        {
            this.logger = logger;
            this.apiClient = apiClient;
            this.configuration = configuration;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery]Request request)
        {
            logger.LogInformation("Ropsten GetAll started",JsonConvert.SerializeObject(request));

            apiClient.ApiBaseUrl = configuration["WebApi:RopstenBaseUrl"];
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}?module={1}&", apiClient.ApiBaseUrl,request.Module);
            sb.AppendFormat("action={0}&", request.Action);
            sb.AppendFormat("address={0}&", request.Address);
            sb.AppendFormat("startblock={0}&", request.Startblock);
            sb.AppendFormat("endblock={0}&", request.Endblock);
            sb.AppendFormat("page={0}&", request.Page);
            sb.AppendFormat("offset={0}&", request.Offset);
            sb.AppendFormat("sort={0}&", request.Sort);
            sb.AppendFormat("apikey={0}", request.Apikey);

            var result = await apiClient.GetAsync<List<Employee>>(sb.ToString());

            if (result.Status!="1")
            {                
                logger.LogInformation("Ropsten GetAll complated with error(s)", JsonConvert.SerializeObject(result));
                return BadRequest(result);
            }                
            else
            {                
                logger.LogInformation("Ropsten GetAll complated successfully", JsonConvert.SerializeObject(result));
                return Ok(result);
            }
        }

    }
}
