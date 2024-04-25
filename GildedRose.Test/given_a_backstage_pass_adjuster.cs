namespace GildedRose.msTest;

public class given_a_backstage_pass_adjuster
{
    protected static InventoryItem AdjustedBackstagePass(int originalSellIn, int originalQuality)
    {
        var itemName = "Backstage Pass";
        var backstagePassItemAdjuster = new BackstagePassItemAdjuster();
        var inventoryItem = new InventoryItem(itemName, originalSellIn, originalQuality);
        backstagePassItemAdjuster.Adjust(inventoryItem);
        return inventoryItem;
    }
}