namespace GildedRose;

public class AgedBrieInventoryItemAdjuster : IInventoryItemAdjuster
{
    public bool Match(InventoryItem item)
    {
        return item.Name.ToLower() == "aged brie";
    }

    public void Adjust(InventoryItem item)
    {
        item.AdjustSellIn(-1);
        item.AdjustQuality(1);
    }
}