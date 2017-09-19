using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using WcfServiceExample.Client.Connected_Services.ServiceReferenceClient;

namespace WcfServiceExample.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleServiceClient peopleServiceClient = new PeopleServiceClient();
            peopleServiceClient.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
            peopleServiceClient.ClientCredentials.UserName.UserName = "michal";
            peopleServiceClient.ClientCredentials.UserName.Password = "michal";

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
