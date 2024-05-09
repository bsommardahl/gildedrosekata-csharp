namespace GildedRose;

public class ConjuredInventoryItemAdjuster : IInventoryItemAdjuster, IInventoryItemAdjusterMatcher
{
    public bool CanAdjust(InventoryItem item)
    {
        throw new NotImplementedException();
    }

    public void Adjust(InventoryItem item)
    {
        item.AdjustSellIn(-1);
        item.AdjustQuality(-2);
    }
}