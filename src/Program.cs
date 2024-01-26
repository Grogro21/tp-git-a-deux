// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using src;
using System.ComponentModel.DataAnnotations.Schema;
List<Person> peoples = new List<Person>();
string nom;
string prenom;
bool isHere;
src.PeopleContainer myContainer = new PeopleContainer(peoples);
do
{
    Console.WriteLine("saisir nom ou saisissez la lettre q pour quitter le programme :");
    nom = Console.ReadLine();
    if (!nom.SequenceEqual("q"))
    {
        Console.WriteLine("Veuillez ajouter un prénom");
        prenom = Console.ReadLine();
        src.Person myPerson = new src.Person(nom, prenom);
        Console.WriteLine(nom + " " + prenom);
        if (myContainer.People == null) //si c'est la première personne, rien à comparer, on l'ajoute au container
        {
            myContainer.People = new List<Person>();
            myContainer.People.Add(myPerson);
        }

        else
        {
            isHere = false;
            foreach (Person p in myContainer.People)  //On parcourt la liste de personnes 
            {
                if (myPerson.Nom.SequenceEqual(p.Nom) || myPerson.Nom.SequenceEqual(p.Prenom)) //Si elle y est déja, on ne l'ajoute pas
                {
                    isHere = true;
                }
            }
            if (!isHere) //Si elle n'y est pas, c'est bon on ajoute
            {
                myContainer.People.Add(myPerson);
            }
        }
    }
} 
while (!nom.SequenceEqual("q"));

if (myContainer.People != null) //obligé de vérifier que le container n'est pas vide sinon ça va crash
    {
    myContainer.People = myContainer.SortByFirstName(); //tri par nom
    src.SerializePeopleContainerToJson toConvert1 = new SerializePeopleContainerToJson(myContainer);
    string JsonFile = toConvert1.SerializeMethod(); 
    string filename = "savefile.json";
    File.WriteAllText(filename, JsonFile); //crée le fichier savefile.json et écrit dedans
    Console.WriteLine(File.ReadAllText(filename));
    }
