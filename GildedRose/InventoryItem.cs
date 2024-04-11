namespace GildedRose;

public class InventoryItem(string name, int sellIn, int quality)
{
    public string Name { get; } = name;
    public int SellIn { get; private set; } = sellIn;
    public int Quality { get; private set; } = quality;

    public void AdjustSellIn(int increment)
    {
        SellIn += increment;
    }

    public void AdjustQuality(int increment)
    {
        var newQuality = Quality + increment;
        Quality = newQuality >= 0 ? newQuality : 0;
    }
    
}