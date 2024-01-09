using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RasuliEEndpoints.Services.Sums.Results;

namespace RasuliEEndpoints.Controllers
{
    public class NumResultController
    {
        readonly private IResultsService _resultsService;
        public NumResultController(IResultsService s){
            _resultsService = s;
        }

        [HttpGet]
        [Route("numResults/{num1}/{num2}")]
        public string[] results(double num1, double num2){
            return _resultsService.results(num1, num2);
        }
    }
}