namespace CrowdSort.Web;

public class CrowdSortApiClient(HttpClient httpClient)
{
    public async Task<HelloReply?> GetGreeterAsync(string name = "World", CancellationToken cancellationToken = default)
    {
        return await httpClient.GetFromJsonAsync<HelloReply>($"/greeter/{name}", cancellationToken);
    }
}

public class HelloReply
{
    public string? message { get; set; }
}
