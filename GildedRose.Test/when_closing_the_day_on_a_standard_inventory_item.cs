using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.msTest;

[TestClass]
public class when_closing_the_day_on_a_standard_inventory_item_that_has_passed_sell_in_date
{
    [TestMethod]
    public void it_should_degrade_quality_twice_as_fast()
    {
        var dayCloser = new InventoryItemDayCloser();
        var originalQuality = 10;
        var oldItemSellIn = 0;
        var inventoryItem = new InventoryItem("Old Cheese", oldItemSellIn, originalQuality);
        var expectedQuality = 8;
        dayCloser.Close(inventoryItem);
        Assert.AreEqual(expectedQuality, inventoryItem.Quality);
    }
}

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