using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using TrotiNative.WebApplication.Controllers;


namespace Trotinative.BigBalllMud.Tests;

public class TrotteControllerTest
{
    [Fact]
    public void SimpleTest()
    {
        var sut = new TrotteController();

        var actual = sut.Get();

        var resultOk = actual.Result.Should().BeAssignableTo<OkObjectResult>().Subject;
        
        var value = (resultOk) .Value.Should().BeAssignableTo<Trotte>().Subject;
        value.estDisponible.Should().BeTrue();
        value.numero.Should().Be("000");

    }
}