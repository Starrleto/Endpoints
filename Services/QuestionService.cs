using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RasuliEEndpoints.Services.Questions;

namespace RasuliEEndpoints.Services
{
    public class QuestionService : IQuestionsService
    {
        public string Question(string name, string time)
        {
            return $"Your name is {name} and you woke up at {time}";
        }
    }
}