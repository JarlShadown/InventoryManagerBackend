namespace InventoryManager.Domain;

public class Location
{
    public int Id { get; set; }
    public required string LocationName { get; set; }
    public required string LicensePlate { get; set; }
    public DateTime CycleCountDate { get; set; }
}