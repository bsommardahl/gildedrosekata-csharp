namespace GildedRose.msTest;

[TestClass]
public class when_closing_the_day_on_a_standard_inventory_item_that_has_passed_sell_in_date
{
    [TestMethod]
    public void it_should_degrade_quality_twice_as_fast()
    {
        var dayCloser = new InventoryItemDayCloser();
        var originalQuality = 10;
        var oldItemSellIn = -1;
        var inventoryItem = new InventoryItem("Old Cheese", oldItemSellIn, originalQuality);
        var expectedQuality = 8;
        dayCloser.Close(inventoryItem);
        Assert.AreEqual(expectedQuality, inventoryItem.Quality);
    }
}