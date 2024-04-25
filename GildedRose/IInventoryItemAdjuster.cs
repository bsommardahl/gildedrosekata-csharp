namespace GildedRose;

public interface IInventoryItemAdjuster
{
    bool Match(InventoryItem item);
    void Adjust(InventoryItem item);
}