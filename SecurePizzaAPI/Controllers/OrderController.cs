using Microsoft.AspNetCore.Mvc;
using SecurePizzaAPI.DTOs;
using SecurePizzaAPI.Models;

namespace SecurePizzaAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private static readonly List<Order> Orders = new();

    [HttpPost]
    public IActionResult CreateOrder(CreateOrderRequest request)
    {
        var order = new Order
        {
            Id = Orders.Count + 1,
            CustomerName = request.CustomerName,
            PizzaType = request.PizzaType,
            Quantity = request.Quantity
        };

        Orders.Add(order);

        return Ok(order);
    }

    [HttpGet]
    public IActionResult GetOrders()
    {
        return Ok(Orders);
    }
}
