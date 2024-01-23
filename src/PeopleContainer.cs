namespace src
{
    public class PeopleContainer
    {
        private List<Person> people;

        public List<Person> People { get => people;}
        public PeopleContainer(List<Person> _people)
        {
            this.people=people;
        }

        
    }

    interface IPersonContainer
    {
        public List<Person> SortByLastName(List<Person>  peoples)
         {
            return(peoples.OrderBy(p=>p.Prenom).ToList());
         }
        List<Person> SortByFirstName(List<Person>  peoples)
        {
            return(peoples.OrderBy(p=>p.Nom).ToList());
        }
    }
}