namespace src
{
    public class Person 
    {
        private string nom;
        private string prenom;
        public string Prenom { get => prenom;  }
        public string Nom { get => nom; }
        public Person(string _nom, string _prenom)
        {
            this.prenom = _prenom;
            this.nom = _nom;
        }
    }
}