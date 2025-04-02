using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using TrotiNative.Locations.WebApplication.Controllers;
using TrotiNative.SharedKernel;


namespace Trotinative.BigBalllMud.Tests;

public class TrotteControllerTests
{
    [Fact(Skip = "design à faire évoluer")]
    public void DevraitRetournerLaPremiereTrotteDispo()
    {
        var sut = new TrotteController();

      //  var parc = new Parc();
        
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
        var sut = new TrotteController();

        var actual = sut.RetourneLaPremiereTrotteDispo();

        var resultNotFoundObjectResult = actual.Result.Should().BeAssignableTo<NotFoundResult>().Subject;
        
 
    }
    
}