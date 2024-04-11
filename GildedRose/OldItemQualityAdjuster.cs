namespace GildedRose;

public class OldItemQualityAdjuster : IQualityAdjuster
{
    public void Adjust(InventoryItem item)
    {
        item.AdjustSellIn(-1);
        item.AdjustQuality(-2);
    }
}