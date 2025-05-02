using CrowdSort.Contracts.Greeter;
using Grpc.Core;

namespace CrowdSort.Services
{
    public class GreetingService : Greeter.GreeterBase
    {
        private readonly ILogger<GreetingService> _logger;
        public GreetingService(ILogger<GreetingService> logger)
        {
            _logger = logger;
        }

        public override Task<GreetReply> GreetGet(GreetRequest request, ServerCallContext context)
        {
            return Task.FromResult(new GreetReply
            {
                Message = $"Hello, {request.Name}!",
            });
        }
    }
}