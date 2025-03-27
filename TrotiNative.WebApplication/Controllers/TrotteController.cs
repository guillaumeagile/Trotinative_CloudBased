using Microsoft.AspNetCore.Mvc;

namespace TrotiNative.WebApplication.Controllers;

[ApiController]
[Route("trotte")]
public class TrotteController  : ControllerBase
{
    [HttpGet("")]
    public ActionResult<Trotte> Get()
    {
        var trotte = new Trotte(numero: "000", true); 
        return Ok(trotte);
    }
}

public record Trotte(string numero, bool estDisponible )
{
}