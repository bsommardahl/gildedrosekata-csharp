namespace GildedRose;

public class AgedBrieQualityAdjuster : IQualityAdjuster
{
    public void Adjust(InventoryItem item)
    {
        item.AdjustQuality(1);
    }
}