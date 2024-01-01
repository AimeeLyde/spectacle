using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AimCecSpect.Billet;
namespace AimCecSpect
{
    internal class GestionnaireBillet
    {
        public event ReservationDelegate Reservation;
        public event AnnulationDelegate Annulation;

        public void ReserverBillet(int IDSpectacle, int idUser)
        {
            if (Reservation != null)
            {
                Reservation(IDSpectacle, idUser);
            }
        }

        public void AnnulerBillet(int IDSpectacle, int idUser)
        {

            if (Annulation != null)
            {
                Annulation(IDSpectacle, idUser);
            }
        }

    }
}
