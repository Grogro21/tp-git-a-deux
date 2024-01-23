namespace src
{
    public class PeopleContainer
    {
        private List<Person> people;

        public string People { get => people;}
        public PeopleContainer(List<Person> _people)
        {
            this.people=people;
        }

        
    }

    interface IPersonContainer
    {
        public List<Person> SortByLastName(peoples)
         {
            return(peoples.OrderBy(p=>p.Prenom));
         }
        List<Person> SortByFirstName(peoples)
        {
            return(peoples.OrderBy(p=>p.Nom));
        }
    }
}