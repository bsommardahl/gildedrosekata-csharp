namespace GildedRose.msTest;

[TestClass]
public class when_adjusting_a_legendary_item
{
    [TestMethod]
    [DataRow(30)]
    [DataRow(80)]
    public void it_should_not_change_the_quality(int originalQuality)
    {
        var adjuster = new LegendaryInventoryItemAdjuster();
        var item = new LegendaryInventoryItem("Sulfuras", 9, originalQuality);
        adjuster.Adjust(item);
        Assert.AreEqual(item.Quality, originalQuality);
    }
}