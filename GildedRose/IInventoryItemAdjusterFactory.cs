namespace GildedRose;

public interface IInventoryItemAdjusterFactory
{
    IInventoryItemAdjuster Create(InventoryItem item);
}