using TrotiNative.SharedKernel;

namespace TrotiNative.Locations.WebApplication.Controllers;

public record Trotte(string Numéro, bool EstDisponible ) : ITrotte
{
}