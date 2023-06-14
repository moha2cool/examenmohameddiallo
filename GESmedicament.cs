using System;
namespace pharmacie
{
    public class GESmedicament
    {
        private List<medicaments> medicament= new List<medicaments>();

        // Ajouter un nouveau medicament
        public void AjouterPatient()
        {
            Console.WriteLine("=== Ajouter un médicament ===");
            Console.Write("Nom : ");
            string Nom = Console.ReadLine();
            medicaments Medicaments= new medicaments

             Console.Writeline(" Id_medicament : ");
            string Id_medicament = Console.ReadLine();

            Console.Write("Prix : ");
            decimal Prix = decimal.Parse(Console.ReadLine());
            Console.Write("Quantité en stock : ");
            int Quantite = int.Parse(Console.ReadLine());
     
            medicament.Add(Medicaments);
            Console.WriteLine("medicament ajouté avec succès !");
        }

        // Obtenir la liste des medicament
        public List<medicaments> ObtenirListeMedicaments()
        {
            return medicament;
        }

        // Rechercher un medicament par son ID
        public medicaments RechercherMedicamentParId(int Id_medicament)
        {
            return medicament.Find(p => p.Id_medicament == Id_medicament);
        }

        // Mettre à jour les informations medicament
        public void MettreAJourmedicaments(int Id_medicament, string Nom, int Quantite, decimal Prix)
        {
          medicaments medicament= RechercherMedicamentParId(Id_medicament);
            if (medicament != null)
            {
                medicament.Nom = Nom;
                medicament.Quantite = Quantite;
                medicament.Prix = Prix;

                Console.WriteLine("Informations du medicament mises à jour avec succès !");
            }
            else
            {
                Console.WriteLine("medicament non trouvé.");
            }
        }

        // Supprimer un medicament
        public void Supprimermedicaments(int id)
        {
          medicaments medic = RechercherMedicamentParId(id);
            if (medic != null)
            {
               medicament.Remove(medic);
                Console.WriteLine("medicament supprimé avec succès !");

            }
            else
            {
                Console.WriteLine("medicament non trouvé.");
            }
        }

        public GESmedicament()
        {
        }
    }

}
