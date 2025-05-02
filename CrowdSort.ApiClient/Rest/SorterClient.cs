using SorterContracts;

namespace CrowdSort.Clients.Rest
{
    public class SorterClient (HttpClient httpClient)
    {
        public async Task<SortsGetReply> GetSortsAsync(CancellationToken cancellationToken = default)
        {
            var responseString = await httpClient.GetStringAsync($"/sorts", cancellationToken);
            var toReturn = SortsGetReply.Parser.ParseJson(responseString);
            return toReturn;
        }

        public async Task<SortGetReply> GetSortAsync(ulong sortId, CancellationToken cancellationToken = default)
        {
            var responseString = await httpClient.GetStringAsync($"/sort/{sortId}", cancellationToken);
            var toReturn = SortGetReply.Parser.ParseJson(responseString);
            return toReturn;
        }
    }
}