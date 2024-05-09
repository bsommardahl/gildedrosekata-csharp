namespace GildedRose;

public class LegendaryInventoryItemAdjuster : IInventoryItemAdjuster, IInventoryItemAdjusterMatcher
{
    public bool CanAdjust(InventoryItem item)
    {
        return item is LegendaryInventoryItem;
    }

    public void Adjust(InventoryItem item)
    {
        //do nothing
    }
}