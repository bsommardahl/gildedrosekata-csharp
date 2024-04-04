using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.msTest;

[TestClass]
public class when_closing_the_day_on_a_standard_inventory_item
{
    private readonly InventoryItemDayCloser _dayCloser = new();
    private InventoryItem _item;

    [TestInitialize]
    public void given_a_standard_inventory_item()
    {
        var name = "Flower";
        var sellIn = 30;
        var quality = 50;
        _item = new InventoryItem(name, sellIn, quality);
    }
    
    [TestMethod]
    public void it_should_reduce_the_sell_in_date_by_one()
    {
        var expectedSellIn = _item.SellIn - 1;
        _dayCloser.Close(_item);
        Assert.AreEqual(expectedSellIn, _item.SellIn);
    }

    [TestMethod]
    public void it_should_reduce_the_quality_by_one()
    {
        var expectedQuality = _item.Quality - 1;
        _dayCloser.Close(_item);
        Assert.AreEqual(expectedQuality, _item.Quality);
    }
}