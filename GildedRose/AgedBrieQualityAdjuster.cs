namespace GildedRose;

public class AgedBrieQualityAdjuster : IQualityAdjuster
{
    public void Adjust(InventoryItem item)
    {
        item.AdjustSellIn(-1);
        item.AdjustQuality(1);
    }
}