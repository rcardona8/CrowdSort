using Grpc.Core;

namespace CrowdSort.Services
{
    public class GreetingService : Greeting.GreetingBase
    {
        private readonly ILogger<GreetingService> _logger;
        public GreetingService(ILogger<GreetingService> logger)
        {
            _logger = logger;
        }

        public override Task<GreetReply> Greeter(GreetRequest request, ServerCallContext context)
        {
            return Task.FromResult(new GreetReply
            {
                Message = $"Hello, {request.Name}!",
            });
        }
    }
}