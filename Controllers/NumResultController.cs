using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RasuliEEndpoints.Services.Sums.Results;

namespace RasuliEEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumResultController
    {
        readonly private IResultsService _resultsService;
        public NumResultController(IResultsService s){
            _resultsService = s;
        }

        [HttpGet]
        [Route("NumResults/{num1}/{num2}")]
        public string[] results(string num1, string num2){
            return _resultsService.results(num1, num2);
        }
    }
}