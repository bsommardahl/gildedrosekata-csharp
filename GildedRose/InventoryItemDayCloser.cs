namespace GildedRose;

public class InventoryItemDayCloser(InventoryItemAdjusterFactory inventoryItemAdjusterFactory)
{
    public void Close(InventoryItem item)
    {
        if (item.SellIn < 0)
            CloseOldItems(item);
        else
            CloseCurrentItems(item);
    }

    private void CloseCurrentItems(InventoryItem item)
    {
        var inventoryItemAdjuster = inventoryItemAdjusterFactory.Create(item);
        inventoryItemAdjuster.Adjust(item);
    }

    private static void CloseOldItems(InventoryItem item)
    {
        item.AdjustSellIn(-1);
        item.AdjustQuality(-2);
    }
}