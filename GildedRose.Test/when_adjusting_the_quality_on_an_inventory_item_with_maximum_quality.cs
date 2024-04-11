namespace GildedRose.msTest;

[TestClass]
public class when_adjusting_the_quality_on_an_inventory_item_with_maximum_quality
{
    [TestMethod]
    public void it_should_never_have_more_than_the_maximum_quality()
    {
        var maximumQuality = 50;
        var item = new InventoryItem("Wine", 10, maximumQuality);
        item.AdjustQuality(1);
        Assert.AreEqual(maximumQuality, item.Quality);
    }
}