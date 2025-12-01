namespace SecurePizzaAPI.DTOs;

public class CreateOrderRequest
{
    public string CustomerName { get; set; } = string.Empty;
    public string PizzaType { get; set; } = string.Empty;
    public int Quantity { get; set; }
}
