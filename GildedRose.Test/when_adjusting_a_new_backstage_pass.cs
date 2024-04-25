namespace GildedRose.msTest;

[TestClass]
public class when_adjusting_a_new_backstage_pass : given_a_backstage_pass_adjuster
{
    private const int OriginalSellIn = 30;
    private const int OriginalQuality = 0;

    [TestMethod]
    public void it_should_increase_in_quality_by_one()
    {
        var item = AdjustedBackstagePass(OriginalSellIn, OriginalQuality);
        Assert.AreEqual(1, item.Quality);
    }

    [TestMethod]
    public void it_should_decrease_the_sell_in_date_by_one()
    {
        var item = AdjustedBackstagePass(30, 0);
        Assert.AreEqual(29, item.SellIn);
    }
}