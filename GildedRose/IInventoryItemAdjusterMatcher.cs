namespace GildedRose;

public interface IInventoryItemAdjusterMatcher
{
    bool CanAdjust(InventoryItem item);
}