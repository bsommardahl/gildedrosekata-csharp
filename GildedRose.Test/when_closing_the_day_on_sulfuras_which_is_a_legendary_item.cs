namespace GildedRose.msTest;

[TestClass]
public class when_closing_the_day_on_sulfuras_which_is_a_legendary_item
{
    private InventoryItemDayCloser _closer;

    [TestInitialize]
    public void given_a_sulfuras_inventory_item()
    {
        _closer = new InventoryItemDayCloser();
    }
    
    [TestMethod]
    public void it_should_never_have_to_be_sold()
    {
        const int originalQuality = 30;
        const int originalSellIn = 40;
        var item = new InventoryItem("Sulfuras", originalSellIn, originalQuality);
        _closer.Close(item);
        
        Assert.AreEqual(originalSellIn, item.SellIn);
    }
    
    //it_should_never_decrease_in_quality
}