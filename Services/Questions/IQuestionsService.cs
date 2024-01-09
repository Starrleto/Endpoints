using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RasuliEEndpoints.Services.Questions
{
    public interface IQuestionsService
    {
        public string Question(string name, string time);
    }
}