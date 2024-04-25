namespace GildedRose.msTest;

[TestClass]
public class when_adjusting_a_backstage_pass_that_is_a_few_days_before_the_event : given_a_backstage_pass_adjuster
{
    [TestMethod]
    [DataRow(10)]
    [DataRow(9)]
    [DataRow(8)]
    [DataRow(7)]
    [DataRow(6)]
    public void it_should_increase_the_quality_by_2(int sellIn)
    {
        var item = AdjustedBackstagePass(sellIn, 20);
        Assert.AreEqual(22, item.Quality);
    }
}