using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers;

[ApiController]
[Route("coffee")]
public class CoffeeController : ControllerBase
{
    [HttpGet("lover")]
    public string GetLover()
    {
        return "I like coffee!";
    }
}
