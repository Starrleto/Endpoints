using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RasuliEEndpoints.Services.Sums.Results;

namespace RasuliEEndpoints.Services
{
    public class ResultsService : IResultsService
    {
        public string[] results(string num1, string num2)
        {
            double n1;
            double n2;

            if(double.TryParse(num1, out n1) && double.TryParse(num2, out n2)){
                if(n1 > n2){
                    return new string[]{$"{n1} is greater than {n2}" , $"{n2} is less than {n1}"};
                }
                else if(n1 < n2){
                    return new string[]{$"{n1} is less than {n2}" , $"{n2} is greater than {n1}"};
                }
                else{
                    return new string[]{$"{n1} is equal to {n2}" , $"{n2} is equal to {n1}"};
                }
            }
            else
                return new string[] {"Input was wrong. Please try again"};
        }
    }
}