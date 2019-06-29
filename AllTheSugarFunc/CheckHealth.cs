using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AllTheSugarFunc
{
    public static class CheckHealth
    {
        [FunctionName("CheckHealth")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "checkhealth")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("CheckHeallth method called.");

            return new OkObjectResult("SUCCESS");
        }
    }
}
