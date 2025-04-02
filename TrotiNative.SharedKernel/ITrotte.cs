namespace TrotiNative.SharedKernel;

public interface ITrotte
{
    string Numéro { get; init; }
    
    string Label() => Numéro + " : " + (EstDisponible ? "Disponible" : "Non Disponible");
    
    bool EstDisponible { get; init; }
}