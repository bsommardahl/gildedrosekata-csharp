namespace GildedRose.msTest;

[TestClass]
public class when_adjusting_a_conjured_item
{
    [TestMethod]
    public void it_should_degrade_quality_at_double_rate()
    {
        var expectedQuality = 18;
        var conjuredInventoryItem = new ConjuredInventoryItem("Some Connjured Item", 10, 20);
        var inventoryItemAdjuster = new ConjuredInventoryItemAdjuster();
        inventoryItemAdjuster.Adjust(conjuredInventoryItem);
        Assert.AreEqual(expectedQuality, conjuredInventoryItem.Quality);
    }
}