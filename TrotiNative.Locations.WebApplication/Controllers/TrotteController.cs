using Microsoft.AspNetCore.Mvc;
using TrotiNative.ParcDeLocation;
using TrotiNative.SharedKernel;

namespace TrotiNative.Locations.WebApplication.Controllers;

[ApiController]
[Route("trotte")]
public class TrotteController  : ControllerBase
{
    [HttpGet("")]
    public ActionResult<ITrotte> RetourneLaPremiereTrotteDispo()
    {
        var parc = new Parc();  // contiendra toutes les trottes new List<Trotte>();

        // est ce que le parc est responsable de savoir si la liste est vide ?
        if (parc.ListeDesTrottes.Count == 0)
            return NotFound();
        
        var trotte = new Trotte(Numéro: "000", true); 
        return Ok(trotte);
    }
}