namespace libCommerciaux
{
    public class Commercial
    {
        private string nom;
        private string prenom;
        private int puissanceVoiture;
        private char categorie;
        private List<NoteFrais> mesNotes; 

        public Commercial() 
        {
            mesNotes = new List<NoteFrais>();
        }

        public Commercial(string nom, string prenom, int puissanceVoiture, char categorie)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.puissanceVoiture = puissanceVoiture;
            this.categorie = categorie;
         

        }

        public List<NoteFrais> getMesNoteFrais() 
        {
            mesNotes = new List<NoteFrais>();
            return mesNotes;
        }

        public Commercial( string nom, string prenom, int puissanceVoiture, char categorie, List<NoteFrais> mesNotes)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.puissanceVoiture = puissanceVoiture;
            this.categorie = categorie;
            mesNotes = new List<NoteFrais>();

        }

        public string getNom() 
        { 
            return this.nom; 
        }

        public string getPrenom() 
        { 
            return this.prenom; 
        }

        public int getPuissanceVoiture() 
        {
            return this.puissanceVoiture; 
        }

        public char getCategorie() 
        { 
            return this.categorie; 
        }

        public void ajouterNote (DateTime date,int nbklm)
        {
            
            mesNotes.Add(new NoteFrais(date,nbklm));
        }

        public override string ToString()
        {
            string str = $"Nom : {nom} Prénom : {prenom} Puissance voiture : {puissanceVoiture} Categorie : {categorie}"; 
            return str;
        }


        public void ajouterNoteFrais(NoteFrais f)
        {
            mesNotes.Add(f);
        }

      






    }
}
