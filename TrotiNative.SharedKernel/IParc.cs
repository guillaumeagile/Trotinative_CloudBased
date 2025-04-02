namespace TrotiNative.SharedKernel;

public interface IParc
{
    IList<ITrotte> ListeDesTrottes { get; }
    void AjouteTrotte(ITrotte trotte);
}

