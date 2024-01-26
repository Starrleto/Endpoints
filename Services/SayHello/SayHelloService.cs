using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RasuliEEndpoints.Services.SayHello;

namespace RasuliEEndpoints.Services
{
    public class SayHelloService :  iSayHelloService
    {
        public string sayHello(string name){
            return "Hello, "+name;
        }
    }
}