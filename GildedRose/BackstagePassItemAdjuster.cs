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
        item.AdjustQuality(1);
    }
}