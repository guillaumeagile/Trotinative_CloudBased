using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using TrotiNative.Locations.WebApplication.Controllers;
using TrotiNative.Locations.WebApplication.Model.Entities;
using TrotiNative.ParcDeLocation;
using TrotiNative.SharedKernel;


namespace Trotinative.BigBalllMud.Tests;

public class TrotteControllerTests
{
    [Fact()]
    public void DevraitRetournerLaPremiereTrotteDispo()
    { 
        var parc = new Parc();
        var sut = new TrotteController( parc);
        
     
        parc.AjouteTrotte(new Trotte("000", true));
        
        var actual = sut.RetourneLaPremiereTrotteDispo();

        var resultOk = actual.Result.Should().BeAssignableTo<OkObjectResult>().Subject;
        
        var value = (resultOk) .Value.Should().BeAssignableTo<ITrotte>().Subject;
        value.EstDisponible.Should().BeTrue();
        value.Numéro.Should().Be("000");
        
        value.Label().Should().Be("000 : Disponible");
    }
    
    [Fact]
    public void DevraitDireQuelleTrotteEstDisponibleSiLeParcNeContientAucune()
    {
        var parc = new Parc();
        var sut = new TrotteController(parc);

        var actual = sut.RetourneLaPremiereTrotteDispo();

        var resultNotFoundObjectResult = actual.Result.Should().BeAssignableTo<NotFoundResult>().Subject;
        
 
    }
    
}