namespace GildedRose;

public class InventoryItemDayCloser
{
    public void Close(InventoryItem item)
    {
        item.AdjustSellIn(-1);

        IQualityAdjuster qualityAdjuster = new DefaultQualityAdjuster();
        if (item.SellIn < 0)
            qualityAdjuster = new OldItemQualityAdjuster();
        else if (item.Name == "Aged Brie")
            qualityAdjuster = new AgedBrieQualityAdjuster();
        
        qualityAdjuster.Adjust(item);
    }
}