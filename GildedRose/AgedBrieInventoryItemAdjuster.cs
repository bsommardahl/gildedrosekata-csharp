namespace GildedRose;

public class AgedBrieInventoryItemAdjuster : IInventoryItemAdjuster, IInventoryItemAdjusterMatcher
{
    public bool CanAdjust(InventoryItem item)
    {
        return item.Name.ToLower() == "aged brie";
    }

    public void Adjust(InventoryItem item)
    {
        item.AdjustSellIn(-1);
        item.AdjustQuality(1);
    }
}