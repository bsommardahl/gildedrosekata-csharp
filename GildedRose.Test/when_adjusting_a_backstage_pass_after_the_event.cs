namespace GildedRose.msTest;

[TestClass]
public class when_adjusting_a_backstage_pass_after_the_event : given_a_backstage_pass_adjuster
{
    [TestMethod]
    public void it_should_have_zero_quality()
    {
        Assert.AreEqual(0, AdjustedBackstagePass(-1, 100).Quality);
    }
}