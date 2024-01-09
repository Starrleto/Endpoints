using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RasuliEEndpoints.Services.Sums.Results;

namespace RasuliEEndpoints.Services
{
    public class ResultsService : IResultsService
    {
        public string[] results(double num1, double num2)
        {
            if(num1 > num2){
                return new string[]{$"{num1} is greater than {num2}" , $"{num2} is less than {num1}"};
            }
            else if(num1 < num2){
                return new string[]{$"{num1} is less than {num2}" , $"{num2} is greater than {num1}"};
            }
            else{
                return new string[]{$"{num1} is equal to {num2}" , $"{num2} is equal to {num1}"};
            }
        }
    }
}