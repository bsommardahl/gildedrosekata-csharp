using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.msTest;

[TestClass]
public class when_closing_the_day_on_a_standard_inventory_item
{
    private readonly InventoryItemDayCloser _dayCloser = new();
    
    [TestMethod]
    public void it_should_reduce_the_sell_in_date_by_one()
    {
        var name = "Flower";
        var sellIn = 30;
        var quality = 50;
        var item = new InventoryItem(name, sellIn, quality);
        
        _dayCloser.Close(item);
        Assert.AreEqual(sellIn - 1, item.SellIn);
    }
}