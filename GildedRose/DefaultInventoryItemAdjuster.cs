namespace GildedRose;

public class DefaultInventoryItemAdjuster : IInventoryItemAdjuster
{
    public void Adjust(InventoryItem item)
    {
        item.AdjustQuality(-1);
        item.AdjustSellIn(-1);
    }
}