using API_Interactive_Lab_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers;

[ApiController]
[Route("coffee")]
public class CoffeeController : ControllerBase
{
    [HttpGet("")]
    public Coffee Get() => Get(null);

    [HttpGet("{name}")]
    public Coffee Get(string? name)
    {
        if (name is null)
            return new Coffee(name: "latte", id: -1);

        return new Coffee(name);
    }

    [HttpGet("lover")]
    public string GetLover()
    {
        return "I like coffee!";
    }
}
