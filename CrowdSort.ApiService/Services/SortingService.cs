using Grpc.Core;
using SorterContracts;

namespace CrowdSort.Services
{
    public class SortingService : Sorter.SorterBase
    {
        private readonly ILogger<SortingService> _logger;
        private List<Sort> _sorts = new ();
        public SortingService(ILogger<SortingService> logger)
        {
            _logger = logger;

            // Seed data for demonstration purposes
            List<Item> items = new()
            {
                new Item { Name = "Item1", Votes = 8 },
                new Item { Name = "Item2", Votes = 6 },
                new Item { Name = "Item3", Votes = 4 },
                new Item { Name = "Item4", Votes = 2 },
                new Item { Name = "Item5", Votes = 0 },
                new Item { Name = "Item6", Votes = 1 },
                new Item { Name = "Item7", Votes = 3 },
                new Item { Name = "Item8", Votes = 5 },
                new Item { Name = "Item9", Votes = 7 },
                new Item { Name = "Item10", Votes = 9 },
            };
            Sort toAdd = new() { Name = "Sort0" };
            toAdd.Items.Add(items);
            _sorts.Add(toAdd);
        }

        public override Task<SortGetReply> SortGet(SortGetRequest request, ServerCallContext context)
        {
            SortGetReply toReturn = new()
            {
                Sort = _sorts[(int)request.SortId],
            };
            return Task.FromResult(toReturn);
        }

        public override Task<SortsGetReply> SortsGet(SortsGetRequest request, ServerCallContext context)
        {
            SortsGetReply toReturn = new()
            {
                Sorts = { _sorts },
            };
            return Task.FromResult(toReturn);
        }
    }
}