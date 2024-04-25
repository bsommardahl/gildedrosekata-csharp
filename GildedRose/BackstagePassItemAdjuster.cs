namespace GildedRose;

public class BackstagePassItemAdjuster : IInventoryItemAdjuster
{
    public bool Match(InventoryItem item)
    {
        return false;
    }

    public void Adjust(InventoryItem item)
    {
        //do nothing
    }
}