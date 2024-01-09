using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RasuliEEndpoints.Services.Sums;

namespace RasuliEEndpoints.Services
{
    public class SumsService : ISumService
    {
        public double sum(double num1, double num2)
        {
            return num1+num2;
        }
    }
}