﻿// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using src;
using System.ComponentModel.DataAnnotations.Schema;
List<Person> peoples = new List<Person>();
string nom;
string prenom;
src.PeopleContainer myContainer = new PeopleContainer(peoples);
do
{
    Console.WriteLine("saisir nom ou saisissez la lettre q pour quitter le programme :");
    nom = Console.ReadLine();
    if(!nom.SequenceEqual("q"))
        { 
        Console.WriteLine("Veuillez ajouter un prénom");
        prenom = Console.ReadLine();
        src.Person myPerson = new src.Person(nom, prenom);
        Console.WriteLine(nom + " " + prenom);
        if (!myContainer.alreadyContains(myPerson))
          {
          myContainer.People.Add(myPerson);
          }
        }

} 
while (!nom.SequenceEqual("q"));
if (myContainer.People.Count > 0)
{
    src.PeopleContainer listeTri = new PeopleContainer(myContainer.SortByFirstName());
    src.SerializePeopleContainerToJson toConvert = new SerializePeopleContainerToJson(listeTri);
    string JsonFile = toConvert.SerializeMethod();
    string filename = "savefile.json";
    File.WriteAllText(filename, JsonFile);
    Console.WriteLine(File.ReadAllText(filename));
}
