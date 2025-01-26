namespace InventoryManager.Domain;

public class Event<T>
{
    public int EventId { get; set; }
    public required string AggregateId { get; set; }
    public required string AggregateType { get; set; }
    public required int AggregateVersion { get; set; }
    public DateTime TimeStamp { get; set; } = DateTime.UtcNow;
    public required int Version { get; set; }
    public required EventContent<T> Content { get; set; }
}

public class EventContent<T>
{
    public required string Location { get; set; }
    public string LicensePlate { get; set; } = string.Empty;
    public required string Item { get; set; }
    public required int Quantity { get; set; }
    public T? ExtraParameters { get; set; }
}