using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceExample.PeopleService.Model;

namespace WcfServiceExample.PeopleService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PeopleService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PeopleService.svc or PeopleService.svc.cs at the Solution Explorer and start debugging.
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
