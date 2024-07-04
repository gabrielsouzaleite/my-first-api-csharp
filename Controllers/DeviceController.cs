using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Get()
    {
        var key = GetCustomKey();

        return Ok(Author);
    }
}
