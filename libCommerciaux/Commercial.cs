namespace libCommerciaux
{
    public class Commercial 
    {
        private string nom;
        private string prenom;
        private int puissanceVoiture;
        private char categorie;
       
        private List<NoteFrais> mesNotes = new List<NoteFrais>();
        private List<Nuite> mesNuites = new List<Nuite>();
        private List<FraisTransport> mesTransports = new List<FraisTransport>();
        private List<RepasMidi> mesRepasMidi = new List<RepasMidi>();


        public Commercial() 
        {
          // mesNotes = new List<NoteFrais>();
        }

        public Commercial(string nom, string prenom, int puissanceVoiture, char categorie)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.puissanceVoiture = puissanceVoiture;
            this.categorie = categorie;
            mesNotes = new List<NoteFrais>();

        }

        public List<NoteFrais> getMesNoteFrais() 
        {
           return this.mesNotes;
        }

        public Commercial( string nom, string prenom, int puissanceVoiture, char categorie, List<NoteFrais> mesNotes)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.puissanceVoiture = puissanceVoiture;
            this.categorie = categorie;
            this.mesNotes = mesNotes;

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

        //Frais Transport 
        public  virtual void ajouterNote (DateTime date,int nbklm)
        {
            
            mesTransports.Add(new FraisTransport(date,nbklm));
            mesNotes.Add(new FraisTransport(date,nbklm));
        }
        
        //Repas Midi
        public virtual  void ajouterNote(DateTime date, double montantfacture)
        {

            mesRepasMidi.Add(new RepasMidi(date, montantfacture));
           
            mesNotes.Add(new RepasMidi(date, montantfacture));
        }

        // Nuités 
       public  virtual void ajouterNote(DateTime date, double montantFacture,char region)
        {
            mesNuites.Add(new Nuite(date,montantFacture,region));
            mesNotes.Add(new Nuite(date, montantFacture, region));
        }


        public virtual string ToString()
        {
            string str = $"Nom : {nom} Prénom : {prenom} Puissance voiture : {puissanceVoiture} Categorie : {categorie}"; 
            return str;
        }


        // Note Frais 
       public void ajouterNoteFrais(NoteFrais f)
        {
            mesNotes.Add(f);
           
           
        }

        public double CumulNoteFraisRembourser (int annee)
        {
            double cumul = 0;
            foreach(NoteFrais f in mesNotes)
            {
                if (f.GetDate().Year == annee)
                {
                    cumul =cumul +  f.calculMontantARembourser();
                }
            }

            return cumul;
        }






    }
}
