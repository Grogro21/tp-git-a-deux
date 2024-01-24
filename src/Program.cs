// See https://aka.ms/new-console-template for more information
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

src.SerializePeopleContainerToJson toConvert = new SerializePeopleContainerToJson(myContainer);
string JsonFile = toConvert.SerializeMethod();

