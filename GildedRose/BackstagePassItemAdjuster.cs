namespace GildedRose;

public class BackstagePassItemAdjuster : IInventoryItemAdjuster
{
    public bool Match(InventoryItem item)
    {
        return false;
    }

    public void Adjust(InventoryItem item)
    {
        item.AdjustSellIn(-1);

        if(item.SellIn <=10)
            item.AdjustQuality(2);
        else
            item.AdjustQuality(1);
    }
}