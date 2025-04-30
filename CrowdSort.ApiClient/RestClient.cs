using System.Net.Http.Json;
using CrowdSort.Services;

namespace CrowdSort.ApiClient
{
    public class RestClient (HttpClient httpClient)
    {
        public async Task<HelloReply?> GetGreeterAsync(string name = "World", CancellationToken cancellationToken = default)
        {
            return await httpClient.GetFromJsonAsync<HelloReply>($"/greeter/{name}", cancellationToken);
        }
    }
}
