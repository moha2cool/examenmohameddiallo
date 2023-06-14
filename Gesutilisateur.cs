using System;
namespace pharmacie
{
	public class Gesutilisateur
	{
        private List<utilisateur> utilisateurs= new List<utilisateur>();

        // Ajouter un nouveau utilisateur
        public void AjouterUtilisateur(int CNI,string nom,string prenom)
           
           
        {
            utilisateur Utilisateur = new utilisateur
            {
                CNI = CNI,
                nom = nom,
                prenom = prenom
          
            };
           utilisateurs.Add(Utilisateur);
            Console.WriteLine("Utilisateur ajouté avec succès !");
        }

        // Obtenir la liste des utilisateur
        public List<utilisateur> ObtenirListeutilisateur()
        {
            return utilisateurs;
        }

        // Rechercher un utilisateur par son CNI
        public utilisateur RechercherUtilisateurParCNI(int CNI)
        {
            return utilisateurs.Find(p => p.CNI == CNI);
        }

        // Mettre à jour les informations d'un utilisateur
        public void MettreAJourUtilisateur(int CNI, string nom, string prenom)
        {
           utilisateur utilisateur = RechercherUtilisateurParCNI(CNI);
            if (utilisateur != null)
            {
               utilisateur.nom = nom;
                utilisateur.prenom = prenom;
              
                Console.WriteLine("Informations de l'utilisateur mises à jour avec succès !");
            }
            else
            {
                Console.WriteLine("utilisateur non trouvé.");
            }
        }

        // Supprimer un un utilisateur
        public void SupprimerUtilisateur(int CNI)
        {
            utilisateur utilisateur = RechercherUtilisateurParCNI(CNI);
            if (utilisateur != null)
            {
                utilisateurs.Remove(utilisateur);
                Console.WriteLine("utilisateur supprimé avec succès !");

            }
            else
            {
                Console.WriteLine("utilisateur non trouvé.");
            }
        }
        public Gesutilisateur()
		{
		}
	}
}

