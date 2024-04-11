namespace GildedRose;

public class DefaultQualityAdjuster : IQualityAdjuster
{
    public void Adjust(InventoryItem item)
    {
        item.AdjustQuality(-1);
    }
}