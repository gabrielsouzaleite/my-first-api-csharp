using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("my-first-api/[controller]")]
[ApiController]
public abstract class MyFirstApiBaseController : ControllerBase
{
    public string Author { get; set; } = "Gabriel Leite";

    [HttpGet("heathy")]
    public IActionResult Heathy()
    {
        return Ok("It's working!");
    }

    protected string GetCustomKey()
    {
        return Request.Headers["MyKey"].ToString();
    }
}
