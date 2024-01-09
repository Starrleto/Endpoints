using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RasuliEEndpoints.Services.Sums;

namespace RasuliEEndpoints.Services
{
    public class SumsService : ISumService
    {
        public string sum(string num1, string num2)
        {
            double n1;
            double n2;

            if(double.TryParse(num1, out n1) && double.TryParse(num2, out n2)){
                return (n1+n2).ToString();
            }
            return "Input must be two whole numbers.";
        }
    }
}