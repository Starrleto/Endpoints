using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RasuliEEndpoints.Services.Sums.Results
{
    public interface IResultsService
    {
        public string[] results(string num1, string num2);
    }
}