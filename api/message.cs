using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace net7iso
{
    public class http1
    {
        private readonly ILogger _logger;

        public http1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<http1>();
        }

        [Function("http1")]
        public string Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            return "THIS IS MY STRING";
        }
    }
}
