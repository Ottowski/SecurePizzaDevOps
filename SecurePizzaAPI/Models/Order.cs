namespace SecurePizzaAPI.Models;

public class Order
{
    public int Id { get; set; }        // Ordernummer
    public string CustomerName { get; set; } = string.Empty;
    public string PizzaType { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public DateTime OrderTime { get; set; } = DateTime.UtcNow;
}
