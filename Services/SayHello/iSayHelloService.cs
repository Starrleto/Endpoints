using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RasuliEEndpoints.Services.SayHello
{
    public interface iSayHelloService
    {
        public string sayHello(string name);
    }
}