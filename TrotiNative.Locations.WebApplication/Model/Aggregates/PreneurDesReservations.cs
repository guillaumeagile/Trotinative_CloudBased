using TrotiNative.ParcDeLocation;
using TrotiNative.SharedKernel;

namespace TrotiNative.Locations.WebApplication.Model.Aggregates;

public class PreneurDesReservations(IParc parc)
{
    public EtatParc EtatDuParc =>
        parc.ListeDesTrottes.Count == 0 ? EtatParc.Vide : EtatParc.Disponible;
}

