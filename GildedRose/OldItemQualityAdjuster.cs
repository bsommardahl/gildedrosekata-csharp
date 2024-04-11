namespace GildedRose;

public class OldItemQualityAdjuster : IQualityAdjuster
{
    public void Adjust(InventoryItem item)
    {
        item.AdjustQuality(-2);
    }
}