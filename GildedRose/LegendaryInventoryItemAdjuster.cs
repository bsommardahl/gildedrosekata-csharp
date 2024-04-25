namespace GildedRose;

public class LegendaryInventoryItemAdjuster : IInventoryItemAdjuster
{
    public bool Match(InventoryItem item)
    {
        return item is LegendaryInventoryItem;
    }

    public void Adjust(InventoryItem item)
    {
        //do nothing
    }
}