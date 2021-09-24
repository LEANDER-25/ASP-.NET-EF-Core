using DEMO_EF_Core.Data;
using DEMO_EF_Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEMO_EF_Core.Controllers
{
    public class UserController : Controller
    {
        private readonly TEST_DBContext context;

        public UserController(TEST_DBContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            List<User> users = this.context.Users.ToList();
            return View(users);
        }
        private User GetUser(int id)
        {
            return this.context.Users.Where(u => u.UserId == id).FirstOrDefault();
            //select * from Users where user_id = id;
        }
        public IActionResult Detail(int id)
        {
            return View(GetUser(id));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(GetUser(id));
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            this.context.Attach(user);
            this.context.Entry(user).State = EntityState.Modified;
            this.context.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(GetUser(id));
        }
        [HttpPost]
        public IActionResult Delete(User user)
        {
            this.context.Attach(user);
            this.context.Entry(user).State = EntityState.Deleted;
            this.context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
