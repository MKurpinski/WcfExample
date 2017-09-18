using System.ServiceModel;

namespace WcfServiceExample.Service
{
    [ServiceContract]
    public interface IPeopleService
    {
        [OperationContract]
        Person GetPerson(int id);

        [OperationContract]
        bool AddPerson(Person person);
    }
}
