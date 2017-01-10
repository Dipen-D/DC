//using Business.Entities.Dtos;
//using Business.Interfaces;
//using Business.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using Web.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;
using System.Net;
using System.Configuration;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        //private IUserBll UserBll = BllManager.GetUserBll();
        private HttpClient client = new HttpClient();

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
            if (ModelState.IsValid)
            {
                System.Threading.Thread.Sleep(1000);
                string userName = Request.Form["UserName"];
                string password = Request.Form["Password"];
                string webApiUrl = ConfigurationManager.AppSettings["WebApiUrl"];

                string url = webApiUrl + "/Account/Login";
                var postData = new { UserName = userName, password = password };
                var a = new JavaScriptSerializer();
                var myContent = a.Serialize(postData);
                var data = System.Text.Encoding.ASCII.GetBytes(myContent);

                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/json";
                webRequest.ContentLength = data.Length;

                using (var stream = webRequest.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }


                LogInModel model = new LogInModel();
                try
                {
                    using (var webResponse = (HttpWebResponse)webRequest.GetResponse())
                    {
                        if (webResponse.StatusCode == HttpStatusCode.OK)
                        {
                            model.IsValidated = true;
                        }
                        else
                        {
                            model.IsValidated = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    model.IsValidated = false;
                }
                return PartialView("_ShowDetails", model);
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
        
        //public ActionResult AddUser()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        string userName = Request.Form["Nickname"];
        //        string pin = Request.Form["TempRegPIN"];
        //        string email = Request.Form["Email"];
        //        string password = Request.Form["Password"];

        //        RegisterUserDto user = new RegisterUserDto();
        //        user.UserName = userName;
        //        user.Email = email;
        //        user.Password = password;
        //        user.Pin = pin;
        //        RegisterViewModel model = new RegisterViewModel();

        //        try
        //        {
        //            UserBll.RegisterUser(user);
        //            model.IsCreated = true;
        //        }
        //        catch (Exception exception)
        //        {
        //            model.IsCreated = false;
        //        }
        //        return PartialView("_RegisterationDetails", model);
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}
    }
}