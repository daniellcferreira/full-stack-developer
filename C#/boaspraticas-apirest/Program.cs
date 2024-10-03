using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("users")]
public class UserController : ControllerBase
{
    private static List<User> users = new List<User>;

    [HttpGet]
    public ActionResult<List<User>> GetUsers()
    {
        return Ok(users);
    }

    [HttpPost]
    public ActionResult<User> CreateUser([FromBody] User user)
    {
        user.add(user);
        return CreatedAction(nameof(GetUser), new {userId = user.Id}, user);
    }

    [HttpGet("{userId}")]
    public ActionResult<User> GetUse(int userId)
    {
        var user = users.FirstOrDefault(u => u.Id == userId);
        if (user == null) return NotFound();
        return Ok(user);
    }

    [HttpPut("{userId}")]
    public ActionResult<User> UpdateUse(int userId, [FromBody] User updatedUser)
    {
        var user = users.FirstOrDefault(u => u.Id == userId);
        if (user == null) return NotFound();
        user.Name = updatedUser.Name;
        return Ok(user);
    }

    [HttpDelete("{userId}")]
    public IActionResult DeleteUse(int userId)
    {
        var user = users.FirstOrDefault(u => u.Id == userId);
        if (user == null) return NotFound();
        users.Remove(user);
        return NoContent();
    }

    [HttpGet("{userId}/orders")]
    public ActionResult<Order> GetOrders(int userId)
    {
        var orders = GetOrdersForUser(userId);
        return Ok(orders);
    }

    [HttpPost("{userId}/orders")]
    public ActionResult<Order> CreateOrders(int userId, [FromBody] Order order)
    {
        AddOrderToUser(userId, order);
        return CreatedAction(nameof(GetOrders), new {userId}, order);
    }

    private List<Order> GetOrdersForUser(int userId)
    {
        return new List<Order>();
    }

    private void AddOrderToUser(int userId, Order order)
    {
        // Função simulada para adicionar pedido
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public string Description { get; set; }   
}