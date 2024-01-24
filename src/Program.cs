// See https://aka.ms/new-console-template for more information
using src;
using System.ComponentModel.DataAnnotations.Schema;
List<Person> peoples = new List<Person>();

do
{
    Console.WriteLine("saisir nom ou saisisez la lettre q pour quitter le programe :");
    string nom = Console.ReadLine();
    Console.WriteLine("Veuilliez ajouter un prénom");
    string prenom = Console.ReadLine();
    src.Person myPerson = new src.Person(nom, prenom);
    Console.WriteLine(nom + " " + prenom);
    peoples.Add(myPerson);
    src.PeopleContainer myContainer = new PeopleContainer(peoples);
    myContainer.People.Add(myPerson);
} while (string nom != "q");

List<Person> peoples = new List<Person>();
