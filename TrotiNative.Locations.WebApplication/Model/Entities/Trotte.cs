using TrotiNative.SharedKernel;

namespace TrotiNative.Locations.WebApplication.Model.Entities;

public record Trotte(string Numéro, bool EstDisponible ) : ITrotte
{
}