namespace GildedRose.msTest;

[TestClass]
public class when_adjusting_a_backstage_pass_as_the_event_approaches
{
    [TestMethod]
    [DataRow(30, 10, 11)]
    [DataRow(15, 10, 11)]
    [DataRow(9, 30, 32)]
    [DataRow(8, 30, 32)]
    [DataRow(7, 30, 32)]
    [DataRow(6, 30, 33)]
    [DataRow(5, 30, 33)]
    [DataRow(4, 30, 33)]
    [DataRow(3, 30, 33)]
    [DataRow(2, 30, 33)]
    [DataRow(1, 30, 33)]
    [DataRow(0, 30, 0)]
    [DataRow(-1, 30, 0)]
    [DataRow(-2, 30, 0)]
    public void it_should_increase_the_quality_as_anticipation_builds_before_the_event(int preAdjustmentSellIn, int originalQuality, int expectedQuality)
    {
        var backstagePassItemAdjuster = new BackstagePassItemAdjuster();
        var inventoryItem = new InventoryItem("Backstage Pass", preAdjustmentSellIn, originalQuality);
        backstagePassItemAdjuster.Adjust(inventoryItem);
        Assert.AreEqual(expectedQuality, inventoryItem.Quality);
    }
}