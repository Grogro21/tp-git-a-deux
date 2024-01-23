namespace src
{
    public class Person
    {
        private string nom;
        private string prenom;
         public double prenom { get => prenom;  }
    public Person(string _nom,string _prenom){
        this.prenom = _prenom;
        this.nom = _nom;
    }
    
    }
}