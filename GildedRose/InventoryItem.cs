namespace GildedRose;

public class InventoryItem
{
    public InventoryItem(string name, int sellIn, int quality)
    {
        SellIn = sellIn;
        Quality = quality;
    }

    public int SellIn { get; private set; }
    public int Quality { get; }

    public void ReduceSellIn()
    {
        SellIn--;
    }
}