using Microsoft.AspNetCore.Mvc;

namespace Api.Controller;

[ApiController]
[Route("[controller]s")]
public class EchoController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Echo()
    {
        return Ok("Hello From Api!");
    }
}