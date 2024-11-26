using System.Collections.ObjectModel;

namespace InventoryManager.Domain.Entities;

public class Inventory
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public int ItemId { get; set; }
    public int LocationId { get; set; }
    public virtual Collection<Item> Item { get; set; }
    public virtual Collection<Location> Location { get; set; }
}