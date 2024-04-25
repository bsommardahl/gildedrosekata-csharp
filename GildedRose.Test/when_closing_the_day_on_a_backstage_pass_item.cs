namespace GildedRose.msTest;

[TestClass]
public class when_closing_the_day_on_a_backstage_pass_item
{
    [TestMethod]
    public void it_should_use_the_backstage_pass_adjuster()
    {
        var closer = new InventoryItemDayCloser(new InventoryItemAdjusterFactory(new[]
        {
            new BackstagePassItemAdjuster()
        }));
        var inventoryItem = new InventoryItem("Backstage Pass", 1, 10);
        closer.Close(inventoryItem);
        Assert.AreEqual(13, inventoryItem.Quality);
    }
}