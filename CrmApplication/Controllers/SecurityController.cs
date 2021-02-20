using CrmApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CrmApplication.Controllers
{
    public class SecurityController : Controller
    {
        private readonly IEmployeeRepo empRepo;

        public SecurityController()
        {

        }
        public SecurityController(IEmployeeRepo empRepo)
		{
            this.empRepo = empRepo;

        }
        // GET: Security
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Employee user)
        {
            var emp = empRepo.GetAll().FirstOrDefault(s => s.UserName == user.UserName && s.Password == user.Password);
            if(emp != null)
			{
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return RedirectToAction("Index", "Home");
			}
			else
			{
                ViewBag.Message = "Your Password or user is invalid.";
                return View();
            }
           
        }

        public ActionResult Logout()
        {
            Session.Clear();//remove session
            return RedirectToAction("Login");
        }
    }
}