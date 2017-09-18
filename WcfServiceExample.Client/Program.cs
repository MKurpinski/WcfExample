using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceExample.Client.ServiceReference1;

namespace WcfServiceExample.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleServiceClient peopleServiceClient = new PeopleServiceClient();

            var person = new Person
            {
                FirstName = "Michal",
                LastName = "Kurpinski"
            };
            peopleServiceClient.AddPerson(person);
            Console.WriteLine(peopleServiceClient.GetPerson(1).FirstName);
            Console.ReadKey();
        }
    }
}
