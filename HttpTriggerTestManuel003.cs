using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace TestManuel.Function
{
    public class HttpTriggerTestManuel003
    {
        private readonly ILogger<HttpTriggerTestManuel003> _logger;

        public HttpTriggerTestManuel003(ILogger<HttpTriggerTestManuel003> logger)
        {
            _logger = logger;
        }

        [Function("HttpTriggerTestManuel003")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger Manuel Test function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions! Testing the Project Manuel has created.");
        }
    }
}
