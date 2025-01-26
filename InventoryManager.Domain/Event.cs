namespace InventoryManager.Domain;

public class Event<T>
{
    public int EventId { get; set; }
    public required string AggregateId { get; set; }
    public required string AggregateType { get; set; }
    public required EventContent<T> AggregateVersion { get; set; }
    public required DateTime TimeStamp { get; set; } = DateTime.UtcNow;
    public required int Version { get; set; }
}

public class EventContent<T>(T especialContent)
{
    public required string Location { get; set; }
    public string LicensePlate { get; set; } = string.Empty;
    public required string Item { get; set; }
    public required int Quantity { get; set; }
    public T? ExtraParameters { get; set; }
}
//
// CREATE TABLE events (
//     id SERIAL PRIMARY KEY,
//     aggregate_type TEXT NOT NULL,
//     event_type TEXT NOT NULL,
//     event_data JSONB NOT NULL,
//     timestamp TIMESTAMP WITH TIME ZONE DEFAULT CURRENT_TIMESTAMP,
//     version INT NOT NULL
// );