using Business.Entities.Dtos;
using Business.Interfaces;
using Business.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using Web.Models;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        private IUserBll UserBll = BllManager.GetUserBll();

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
        }

        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Validate()
        {
            System.Threading.Thread.Sleep(3000);
            if (ModelState.IsValid)
            {
                string userName = Request.Form["UserName"];
                string password = Request.Form["Password"];
                UserDto userDto = UserBll.GetUser(userName, password);
                LogInModel model = new LogInModel();
                if (userDto == null)
                {
                    model.IsValidated = false;
                    return PartialView("_ShowDetails", model);
                }
                else
                {
                    model.IsValidated = true;
                    return PartialView("_ShowDetails", model);
                }
            }
            else
            {
                return View();
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult AddUser()
        {
            if (ModelState.IsValid)
            {
                string userName = Request.Form["Nickname"];
                string pin = Request.Form["TempRegPIN"];
                string email = Request.Form["Email"];
                string password = Request.Form["Password"];

                RegisterUserDto user = new RegisterUserDto();
                user.UserName = userName;
                user.Email = email;
                user.Password = password;
                user.Pin = pin;
                RegisterViewModel model = new RegisterViewModel();

                try
                {
                    UserBll.RegisterUser(user);
                    model.IsCreated = true;
                }
                catch (Exception exception)
                {
                    model.IsCreated = false;
                }
                return PartialView("_RegisterationDetails", model);
            }
            else
            {
                return View();
            }
        }
    }
}