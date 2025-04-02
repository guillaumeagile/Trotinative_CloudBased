using TrotiNative.SharedKernel;

namespace TrotiNative.ParcDeLocation;

public class Parc : IParc
{
    public IList<ITrotte> ListeDesTrottes { get;  } = new List<ITrotte>();


    public void AjouteTrotte(ITrotte trotte)
    {
        ListeDesTrottes.Add(trotte);
    }
}

public enum EtatParc
{
    Vide,
    Disponible
}