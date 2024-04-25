namespace GildedRose;

public class DefaultInventoryItemAdjuster : IInventoryItemAdjuster
{
    public bool Match(InventoryItem item)
    {
        return false; //only use the default if no other matches
    }

    public void Adjust(InventoryItem item)
    {
        item.AdjustSellIn(-1);
        item.AdjustQuality(-1);
    }
}