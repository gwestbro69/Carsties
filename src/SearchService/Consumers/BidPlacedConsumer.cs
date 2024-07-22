using MassTransit;
using MongoDB.Entities;
using Polly;
using Contracts;

namespace SearchService;

public class BidPlacedConsumer : IConsumer<BidPlaced>
{
    public async Task Consume(ConsumeContext<BidPlaced> context)
    {
        var auction = await DB.Find<Item>().OneAsync(context.Message.AuctionId);
        
        if (context.Message.BidStatus.Contains("Accepted")
        && context.Message.Amount > auction.CurrentHighBid)
        {
            auction.CurrentHighBid = context.Message.Amount;
            await auction.SaveAsync();
        }
    }
}
