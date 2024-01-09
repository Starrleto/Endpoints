using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RasuliEEndpoints.Services.Sums;

namespace RasuliEEndpoints.Controllers
{
    public class SumController
    {
        readonly private ISumService _sumService;
        public SumController(ISumService s){
            _sumService = s;
        }

        [HttpGet]
        [Route("getSum/{num1}/{num2}")]
        public double sum(double num1, double num2)
        {
            return _sumService.sum(num1, num2);
        }
    }
}