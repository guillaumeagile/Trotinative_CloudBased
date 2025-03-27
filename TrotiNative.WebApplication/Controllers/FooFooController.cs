using Microsoft.AspNetCore.Mvc;

namespace TrotiNative.WebApplication.Controllers;

[ApiController]
[Route("foofoo")]
public class FooFooController  : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get()
    {
        return Ok("foo");
    }
}