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
        private BilleterieEntities _contexte;

        public GestionnaireBillet(BilleterieEntities contexte)
        {
            _contexte = contexte;
        }
        /*        public void ReserverBillet(int IDSpectacle, int idUtilisateur)
                {
                    Utilisateur utilisateur = _contexte.Utilisateurs.FirstOrDefault(u => u.idUser == idUtilisateur);
                    if (Reservation != null)
                    {
                        utilisateur.historiqueReservations.Add(IDSpectacle);
                        _contexte.SaveChanges();
                        Reservation(IDSpectacle, idUtilisateur);
                    }
                }*/

        /*public void ReserverBillet(int idSpectacle, int idUtilisateur)
        {
            // Récupérer l'utilisateur à partir de l'ID
            Utilisateur utilisateur = _contexte.Utilisateurs.FirstOrDefault(u => u.idUser == idUtilisateur);

            if (utilisateur != null)
            {
                // Ajouter l'ID du spectacle à l'historique de réservations de l'utilisateur
                if (!utilisateur.historiqueReservations.Contains(idSpectacle))
                {
                    utilisateur.historiqueReservations.Add(idSpectacle);

                    try
                    {
                        // Sauvegarder les modifications dans la base de données
                        _contexte.SaveChanges();

                        // Déclencher l'événement Reservation s'il y a des abonnés
                        Reservation?.Invoke(idSpectacle, idUtilisateur);
                    }
                    catch (Exception ex)
                    {
                        // Gérer l'exception si la sauvegarde échoue (ex : afficher un message d'erreur, journaliser, etc.)
                        Console.WriteLine($"Erreur lors de la réservation : {ex.Message}");
                        // Vous pouvez gérer l'exception selon votre logique métier
                    }
                }
                else
                {
                    // Gérer le cas où l'utilisateur essaie de réserver le même spectacle à nouveau
                    Console.WriteLine("L'utilisateur a déjà réservé ce spectacle.");
                    // Vous pouvez afficher un message ou gérer cette situation selon votre logique
                }
            }
            else
            {
                // Gérer le cas où l'utilisateur avec cet ID n'est pas trouvé
                Console.WriteLine("Utilisateur non trouvé.");
                // Vous pouvez afficher un message ou gérer cette situation selon votre logique
            }
        }*/

        public void ReserverBillet(int idSpectacle, int idUtilisateur)
        {
            // Récupérer l'utilisateur à partir de l'ID
            Utilisateur utilisateur = _contexte.Utilisateurs.FirstOrDefault(u => u.idUser == idUtilisateur);

            if (utilisateur != null)
            {
                // Créer un nouveau billet associé au spectacle
                Billet billet = new Billet
                {
                    idSpectacle = idSpectacle,
                    idUtilisateur = idUtilisateur,
                    statutReservation = "Réservé" // Mettez le statut approprié ici
                };

                // Ajouter le nouveau billet à la collection de billets de l'utilisateur
                utilisateur.Billets.Add(billet);

                try
                {
                    // Sauvegarder les modifications dans la base de données
                    _contexte.SaveChanges();

                    // Maintenant, billet.idBillet contiendra l'ID du billet nouvellement créé
                    int nouveauIDBillet = billet.idBillet;

                    // Déclencher l'événement Reservation s'il y a des abonnés
                    Reservation?.Invoke(idSpectacle, idUtilisateur);
                }
                catch (Exception ex)
                {
                    // Gérer l'exception si la sauvegarde échoue (ex : afficher un message d'erreur, journaliser, etc.)
                    Console.WriteLine($"Erreur lors de la réservation : {ex.Message}");
                    // Vous pouvez gérer l'exception selon votre logique métier
                }
            }
            else
            {
                // Gérer le cas où l'utilisateur avec cet ID n'est pas trouvé
                Console.WriteLine("Utilisateur non trouvé.");
                // Vous pouvez afficher un message ou gérer cette situation selon votre logique
            }
        }



        public void AnnulerBillet(int IDSpectacle, int idUtilisateur)
        {

            if (Annulation != null)
            {
                Annulation(IDSpectacle, idUtilisateur);
            }
        }

    }
}
