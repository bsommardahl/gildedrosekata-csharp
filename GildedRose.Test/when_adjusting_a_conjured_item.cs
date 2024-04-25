namespace GildedRose.msTest;

[TestClass]
public class when_adjusting_a_conjured_item
{
    [TestMethod]
    [DataRow(10, 10, 8)]
    [DataRow(0, 0, 0)]
    public void it_should_degrade_quality_at_double_rate(int preAdjustmentSellIn, int originalQuality, int adjustedQuality)
    {
        var conjuredInventoryItem = new ConjuredInventoryItem("Some Conjured Item", preAdjustmentSellIn, originalQuality);
        var inventoryItemAdjuster = new ConjuredInventoryItemAdjuster();
        inventoryItemAdjuster.Adjust(conjuredInventoryItem);
        Assert.AreEqual(adjustedQuality, conjuredInventoryItem.Quality);
    }
}