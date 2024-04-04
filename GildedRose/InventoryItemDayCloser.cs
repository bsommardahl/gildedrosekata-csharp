namespace GildedRose;

public class InventoryItemDayCloser
{
    public void Close(InventoryItem item)
    {
        item.ReduceSellIn();
    }
}