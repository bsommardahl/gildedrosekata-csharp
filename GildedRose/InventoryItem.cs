namespace GildedRose;

public class InventoryItem
{
    public InventoryItem(string name, int sellIn, int quality)
    {
        SellIn = sellIn;
    }

    public int SellIn { get; }
}