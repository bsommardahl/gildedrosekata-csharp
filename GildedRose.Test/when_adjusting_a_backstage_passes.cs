namespace GildedRose.msTest;

[TestClass]
public class when_adjusting_a_backstage_passes
{
    private InventoryItem _inventoryItem;

    [TestInitialize]
    public void given_a_backstage_pass_adjuster()
    {
        var backstagePassItemAdjuster = new BackstagePassItemAdjuster();
        _inventoryItem = new InventoryItem("Backstage Pass", 30, 0);
        backstagePassItemAdjuster.Adjust(_inventoryItem);
    }
    
    [TestMethod]
    public void it_should_increase_in_quality_by_one()
    {
        Assert.AreEqual(1, _inventoryItem.Quality);
    }

    [TestMethod]
    public void it_should_decrease_the_sell_in_date_by_one()
    {
        Assert.AreEqual(29, _inventoryItem.SellIn);
    }
}