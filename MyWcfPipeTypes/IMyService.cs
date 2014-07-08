using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace MyWcfPipeTypes
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        String Hello(String Name);

        [OperationContract]
        Person GetPerson();
    }
}
