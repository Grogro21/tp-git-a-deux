// See https://aka.ms/new-console-template for more information
Console.WriteLine("saisir nom");
string nom=Console.ReadLine() ;
Console.WriteLine("saisir prenom");
string prenom=Console.ReadLine() ;
Person myPerson= new Person(nom,prenom);
Console.WriteLine(nom+" "+prenom)
PersonneContainer myContainer= new PersonContainer
