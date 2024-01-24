// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using src;

Console.WriteLine("saisir nom");
string nom=Console.ReadLine() ;
Console.WriteLine("saisir prenom");
string prenom=Console.ReadLine() ;
src.Person myPerson= new src.Person(nom,prenom);
Console.WriteLine(nom+" "+prenom);
List<Person>  peoples = new List<Person>();
src.PeopleContainer myContainer = new PeopleContainer(peoples);
//Inserer le code pour ajouter des personnes ici
//
if (!myContainer.alreadyContains(myPerson))
{
    myContainer.People.Add(myPerson);
}

src.PeopleContainer listeTri = myContainer.SortByFirstName();
src.SerializePeopleContainerToJson toConvert = new SerializePeopleContainerToJson(myContainer);
string JsonFile = toConvert.SerializeMethod();
string filename = "savefile.json";
File.WriteAllText(filename, JsonFile);
Console.WriteLine(File.ReadAllText(filename));

