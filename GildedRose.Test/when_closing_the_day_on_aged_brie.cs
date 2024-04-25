namespace GildedRose.msTest;

[TestClass]
public class when_closing_the_day_on_aged_brie
{
    [TestMethod]
    public void it_should_increase_the_quality_as_the_item_gets_older()
    {
        var inventoryItemDayCloser = new InventoryItemDayCloser(new InventoryItemAdjusterFactory(new List<IInventoryItemAdjuster>()
        {
            new AgedBrieInventoryItemAdjuster()
        }));
        var startingQuality = 20;
        var inventoryItem = new InventoryItem("Aged Brie", 10, startingQuality);
        inventoryItemDayCloser.Close(inventoryItem);
        var expectedQuality = 21;
        Assert.AreEqual(expectedQuality, inventoryItem.Quality);
    }
    
    [TestMethod]
    public void it_should_decrease_the_quality_when_sell_in_is_zero()
    {
        var inventoryItemDayCloser = new InventoryItemDayCloser(new InventoryItemAdjusterFactory(new List<IInventoryItemAdjuster>()));
        var startingQuality = 20;
        var oldItemSellIn = -1;
        var inventoryItem = new InventoryItem("Aged Brie", oldItemSellIn, startingQuality);
        inventoryItemDayCloser.Close(inventoryItem);
        var expectedQuality = 18;
        Assert.AreEqual(expectedQuality, inventoryItem.Quality);
    }
}