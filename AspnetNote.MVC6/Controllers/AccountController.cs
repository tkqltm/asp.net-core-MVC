using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetNote.MVC6.DataContext;
using AspnetNote.MVC6.Models;
using AspnetNote.MVC6.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspnetNote.MVC6.Controllers
{
    public class AccountController : Controller
    {
        // 로그인
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            // ID , 비밀번호 필수
            if(ModelState.IsValid)
            {
                using (var db = new AspnetNoteDbContext())
                {
                    // Linq - 메서드 체이닝
                    // => : A Go to B
                    var user = db.Users.FirstOrDefault(u => u.UserID.Equals(model.UserID) &&
                                                       u.Userpassword.Equals(model.Userpassword));
                    if (user != null)
                    {
                        // 로그인에 성공 했을때
                        HttpContext.Session.SetInt32("USER_LOGIN_KEY",user.UserNo);
                        return RedirectToAction("LoginSuccess", "Home"); // 로그인 성공 페이지로 이동                       
                    }
                    
                }
                // 로그인에 실패 했을때
                ModelState.AddModelError(string.Empty, "사용자의 정보가 옳바르지 않습니다.");
            }
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("USER_LOGIN_KEY");
            return RedirectToAction("Index", "Home");
        }

        // 회원가입
        public IActionResult Register()
        {
            return View();
        }


        // 회원가입 전송
        [HttpPost]
        public IActionResult Register(User model)
        {
            if(ModelState.IsValid)
            {
                using (var db = new AspnetNoteDbContext())
                {
                    db.Users.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("Index", "Home");

            }
            return View(model);
        }
    }
}
