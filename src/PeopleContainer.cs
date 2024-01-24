using System.Text.Json;

namespace src
{
    public class PeopleContainer : IPersonContainer
    {
        private List<Person> people;

        public List<Person> People { get => people; set => people = value; }

        public PeopleContainer(List<Person> _people)
        {
            this.people=people;
        }

        public bool alreadyContains(Person person)
        {
            if (people.Contains(person))
            {
                return false;
            }
            return true;
        }
        public List<Person> SortByLastName()
        {
            return (people.OrderBy(p => p.Prenom).ToList());
        }
        public List<Person> SortByFirstName()
        {
            return (people.OrderBy(p => p.Nom).ToList());
        }
    }

    interface IPersonContainer
    {
        List<Person> SortByLastName();
        List<Person> SortByFirstName();
    }

    public class SerializePeopleContainerToJson
    {
        private PeopleContainer people;
        public SerializePeopleContainerToJson(PeopleContainer _people)
        {
            this.people = _people;
        }

        public string SerializeMethod()
        {
            return JsonSerializer.Serialize(this.people);
        }
    }
}