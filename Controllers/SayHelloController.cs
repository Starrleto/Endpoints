using Microsoft.AspNetCore.Mvc;
using RasuliEEndpoints.Services.SayHello;
namespace RasuliESayHello.Controller;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
    readonly private iSayHelloService _sayHello;
    public SayHelloController(iSayHelloService i){
        _sayHello = i;
    }

    [HttpGet]
    [Route("sayHello/{name}")]
    public string sayHello(string name){
        return _sayHello.sayHello(name);
    }

}