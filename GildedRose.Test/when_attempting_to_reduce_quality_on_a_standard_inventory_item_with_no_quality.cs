namespace GildedRose.msTest;

[TestClass]
public class when_closing_the_day_on_a_standard_inventory_with_no_quality_left
{
    [TestMethod]
    public void it_should_still_have_no_quality()
    {
        var dayCloser = new InventoryItemDayCloser(new InventoryItemAdjusterFactory(new IInventoryItemAdjuster[]
            { new LegendaryInventoryItemAdjuster(), new AgedBrieInventoryItemAdjuster() }));
        var noQuality = 0;
        var inventoryItem = new InventoryItem("Old Milk", 1, noQuality);
        dayCloser.Close(inventoryItem);
        var expectedQuality = 0;
        Assert.AreEqual(expectedQuality, inventoryItem.Quality);
    }
}