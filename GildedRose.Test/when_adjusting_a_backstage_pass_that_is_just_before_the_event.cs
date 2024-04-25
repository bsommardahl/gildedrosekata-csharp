namespace GildedRose.msTest;

[TestClass]
public class when_adjusting_a_backstage_pass_that_is_just_before_the_event : given_a_backstage_pass_adjuster
{
    [TestMethod]
    [DataRow(5)]
    [DataRow(4)]
    [DataRow(3)]
    [DataRow(2)]
    [DataRow(1)]
    [DataRow(0)]
    public void it_should_increase_the_quality_by_3(int sellIn)
    {
       Assert.AreEqual(33, AdjustedBackstagePass(sellIn, 30).Quality); 
    }
}