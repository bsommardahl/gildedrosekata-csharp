namespace GildedRose.msTest;

[TestClass]
public class when_closing_the_day_on_a_legendary_item
{
    private InventoryItem _item;
    const int OriginalQuality = 30;
    const int OriginalSellIn = 40;

    [TestInitialize]
    public void given_an_inventory_item_closer()
    {
        var closer = new InventoryItemDayCloser(new InventoryItemAdjusterFactory(new List<IInventoryItemAdjuster>()
        {
            new LegendaryInventoryItemAdjuster()
        }));
        
        _item = new LegendaryInventoryItem("Sulfuras", OriginalSellIn, OriginalQuality);
        closer.Close(_item);
    }
    
    [TestMethod]
    public void it_should_never_have_to_be_sold()
    {
        Assert.AreEqual(OriginalSellIn, _item.SellIn);
    }

    [TestMethod]
    public void it_should_never_decrease_in_quality()
    {
        Assert.AreEqual(OriginalQuality, _item.Quality);
    }
}