using Microsoft.AspNetCore.Mvc;
using TrotiNative.Locations.WebApplication.Aggregates;
using TrotiNative.ParcDeLocation;
using TrotiNative.SharedKernel;

namespace TrotiNative.Locations.WebApplication.Controllers;

[ApiController]
[Route("trotte")]
public class TrotteController  : ControllerBase
{
    private readonly PreneurDesReservations _preneurDesReservations;

    public TrotteController(IParc parc) 
    {
         _preneurDesReservations = new PreneurDesReservations( parc);
    }
    
    [HttpGet("")]
    public ActionResult<ITrotte> RetourneLaPremiereTrotteDispo()
    {
        if (_preneurDesReservations.EtatDuParc == EtatParc.Vide)
            return NotFound();
        
        var trotte = new Trotte(Numéro: "000", true); 
        return Ok(trotte);
    }
}

