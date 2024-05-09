namespace GildedRose;

public class InventoryItemAdjusterFactory(IEnumerable<IInventoryItemAdjuster> adjusters) : IInventoryItemAdjusterFactory
{
    public IInventoryItemAdjuster Create(InventoryItem item)
    {
        var adjuster = adjusters
            .Where(x=> x is IInventoryItemAdjusterMatcher)
            .FirstOrDefault(x => ((IInventoryItemAdjusterMatcher)x).CanAdjust(item), 
                new DefaultInventoryItemAdjuster());
        return adjuster;
    }
}