using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RasuliEEndpoints.Services.Sums;

namespace RasuliEEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SumController
    {
        readonly private ISumService _sumService;
        public SumController(ISumService s){
            _sumService = s;
        }

        [HttpGet]
        [Route("GetSum/{num1}/{num2}")]
        public string sum(string num1, string num2)
        {
            return _sumService.sum(num1, num2);
        }
    }
}