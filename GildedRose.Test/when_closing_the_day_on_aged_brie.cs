namespace GildedRose.msTest;

[TestClass]
public class when_closing_the_day_on_aged_brie
{
    [TestMethod]
    public void it_should_increase_the_quality_as_the_item_gets_older()
    {
        var inventoryItemDayCloser = new InventoryItemDayCloser();
        var startingQuality = 20;
        var inventoryItem = new InventoryItem("Aged Brie", 10, startingQuality);
        inventoryItemDayCloser.Close(inventoryItem);
        var expectedQuality = 21;
        Assert.AreEqual(expectedQuality, inventoryItem.Quality);
    }
}