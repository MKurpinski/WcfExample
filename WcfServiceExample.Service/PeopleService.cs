using System.Collections.Concurrent;
using System.Linq;

namespace WcfServiceExample.Service
{
    public class PeopleService : IPeopleService
    {
        private static ConcurrentDictionary<int, Person> _people = new ConcurrentDictionary<int, Person>();
        public Person GetPerson(int id)
        {
            _people.TryGetValue(id, out Person person);
            return person;
        }

        public bool AddPerson(Person person)
        {
            var maxId = _people.Count > 0 ? _people.Keys.Max() : 0;
            person.Id = ++maxId;
            var result = _people.TryAdd(person.Id, person);
            return result;
        }
    }
}
