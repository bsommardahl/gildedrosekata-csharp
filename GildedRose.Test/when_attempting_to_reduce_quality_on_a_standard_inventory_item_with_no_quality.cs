namespace GildedRose.msTest;

[TestClass]
public class when_attempting_to_reduce_quality_on_a_standard_inventory_item_with_no_quality
{
    [TestMethod]
    public void it_should_still_have_no_quality()
    {
        var noQuality = 0;
        var inventoryItem = new InventoryItem("Old Milk", 1, noQuality);
        inventoryItem.ReduceQuality();
        var expectedQuality = 0;
        Assert.AreEqual(expectedQuality, inventoryItem.Quality);
    }
}