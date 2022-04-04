using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete.Models;
using ExamSystem.MVC.Models;
using ExamSystem.Services.Extensions;
using ExamSystem.Shared.Data;

namespace ExamSystem.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserRepository _repository;
        public LoginController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginDto loginDto)
        {
            var user = _repository.GetQuery().FirstOrDefault(x => x.Email == loginDto.Email && x.Password == loginDto.Password);
            if (user!= null)
            {
                HttpContext.Session.Clear();
                HttpContext.Session.SetObject<User>("userInfo", user);
                return RedirectToAction("Index", "Exam");
            }

            return View();

        }
    }
}
