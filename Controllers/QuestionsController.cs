using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RasuliEEndpoints.Services.Questions;

namespace RasuliEEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionsController
    {
        readonly private IQuestionsService _questionsService;
        public QuestionsController(IQuestionsService s){
            _questionsService = s;
        }

        [HttpGet]
        [Route("Questions/{name}/{time}")]
        public string Question(string name, string time){
            return _questionsService.Question(name, time);
        }
    }
}