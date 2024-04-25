namespace GildedRose;

public class BackstagePassItemAdjuster : IInventoryItemAdjuster
{
    public bool Match(InventoryItem item)
    {
        return false;
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