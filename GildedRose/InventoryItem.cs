namespace GildedRose;

public class InventoryItem
{
    public InventoryItem(string name, int sellIn, int quality)
    {
        SellIn = sellIn;
        Quality = quality;
    }

    public int SellIn { get; private set; }
    public int Quality { get; private set; }

    public void ReduceSellIn()
    {
        SellIn--;
    }

    public void ReduceQuality()
    {
        if (SellIn < 0) Quality -= 2;
        else Quality--;
    }
}