namespace src
{
    public class PeopleContainer : IPersonContainer
    {
        private List<Person> people;

        public string People { get => people;}
        public PeopleContainer(_people)
        {
            this.people=people;
        }

        
    }

    interface IPersonContainer
    {
        public List<Person> SortByLastName()
         {
            return(this.People.OrderBy(p=>p.Prenom));
         }
        List<Person> SortByFirstName()
        {
            return(this.People.OrderBy(p=>p.Nom));
        }
    }
}