using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimCecSpect
{
    internal class AuthContext : DbContext
    {
        // DbSet pour les utilisateurs
        public DbSet<Utilisateur> Utilisateur { get; set; }

        // Méthode pour authentifier l'utilisateur
        public Utilisateur AuthentifierUtilisateur(string nomUtilisateur, string motDePasseU)
        {
            // Recherche de l'utilisateur correspondant aux informations d'identification
            return Utilisateur.FirstOrDefault(u => u.nom==nomUtilisateur && u.motDePasse==motDePasseU);
        }   
    }
}
