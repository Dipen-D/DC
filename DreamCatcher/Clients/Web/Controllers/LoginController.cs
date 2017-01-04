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
        public IMembershipService MembershipService { get; set; }
        public IFormsAuthenticationService FormsService { get; set; }

        protected override void Initialize(RequestContext requestContext)
        {
            if (FormsService == null)
            {
                FormsService = new FormsAuthenticationService();
            }
            if (MembershipService == null)
            {
                MembershipService = new AccountMembershipService();
            }

            base.Initialize(requestContext);
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(LogInModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (MembershipService.ValidateUser(model.UserName, model.Password))
                {
                    FormsService.SignIn(model.UserName, model.RememberMe);
                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "The user name or password provided is incorrect.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }
    }
}