using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExamResultAPI.Domain;
using System;

namespace ExamResultAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamResultController : ControllerBase
    {
        [HttpGet("quiz")]

        public ExamResult AddQuiz(double quiz1, double quiz2, double quiz3)
        {
            double quiz = (quiz1 + quiz2 + quiz3) / 3;




            var result = new ExamResult
            {
                Quiz = quiz,
            };   

            return result;

        }

        [HttpGet("action")]

        public ExamResult Add(double quiz, double midtermGrade, double finalGrade)
        {
          

            double overallGrade =  (quiz*0.1+ midtermGrade*0.3+ finalGrade*0.6);


            var result = new ExamResult
            {   Quiz=  quiz,
                MidtermGrade = midtermGrade,
                FinalGrade = finalGrade,
                OverallResult = overallGrade
            };

            return result; 

        }
    }
}
