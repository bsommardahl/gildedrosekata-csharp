namespace GildedRose;

public class InventoryItemAdjusterFactory(IEnumerable<IInventoryItemAdjuster> adjusters) : IInventoryItemAdjusterFactory
{
    public IInventoryItemAdjuster Create(InventoryItem item)
    {
        var adjuster = adjusters
            .FirstOrDefault(x => x.Match(item), 
                new DefaultInventoryItemAdjuster());
        return adjuster;
    }
}