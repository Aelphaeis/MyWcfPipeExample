using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MyWcfPipeTypes
{
    [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any, InstanceContextMode = InstanceContextMode.Single)]
    public class MyService : IMyService
    {
        public String Hello(String Name)
        {
            return "Hello " + Name;
        }

        public Person GetPerson()
        {
            return new Person() { Age = 21 };
        }
    }
}
