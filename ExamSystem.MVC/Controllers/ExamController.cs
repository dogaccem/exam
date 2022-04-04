using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamSystem.MVC.Models;

namespace ExamSystem.MVC.Controllers
{
    public class ExamController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromBody]List<ExamDto> examDto)
        {
            //Exams.Add(new ExamDto()
            //{
            //    Question = examDto.Question,
            //    Answers = examDto.Answers,
            //    CorrectAnswer = examDto.CorrectAnswer
            //});
            //Exams.Add(new ExamDto()
            //{
            //    Question = examDto.Question,
            //    Answers = examDto.Answers,
            //    CorrectAnswer = examDto.CorrectAnswer
            //});
            //Exams.Add(new ExamDto()
            //{
            //    Question = examDto.Question,
            //    Answers = examDto.Answers,
            //    CorrectAnswer = examDto.CorrectAnswer
            //});
            //Exams.Add(new ExamDto()
            //{
            //    Question = examDto.Question,
            //    Answers = examDto.Answers,
            //    CorrectAnswer = examDto.CorrectAnswer
            //});


            return View();
        }
    }
}
