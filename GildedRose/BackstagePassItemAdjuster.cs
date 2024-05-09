namespace GildedRose;

public class BackstagePassItemAdjuster : IInventoryItemAdjuster, IInventoryItemAdjusterMatcher
{
    public bool CanAdjust(InventoryItem item)
    {
        return item.Name == "Backstage Pass";
    }

    public void Adjust(InventoryItem item)
    {
        item.AdjustSellIn(-1);
        item.AdjustQuality(item.SellIn switch
        {
            < 0 => item.Quality * -1,
            < 6 => 3,
            <= 10 => 2,
            _ => 1
        });

    }
}