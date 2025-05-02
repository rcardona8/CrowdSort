using System.Net.Http.Json;
using CrowdSort.Contracts.Greeter;

namespace CrowdSort.Clients.Rest
{
    public class GreeterClient (HttpClient httpClient)
    {
        public async Task<GreetReply?> GetGreetingAsync(string name = "World", CancellationToken cancellationToken = default)
        {
            return await httpClient.GetFromJsonAsync<GreetReply>($"/greet/{name}", cancellationToken);
        }
    }
}
