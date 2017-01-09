using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Business.Entities.Dtos;
using Business.Interfaces;
using Business.Locator;

namespace WebApi.Controllers
{
    public class LoginController : ApiController
    {
        private IUserBll UserBll = BllManager.GetUserBll();
        // GET: api/Login
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Login/5
        public string Get(string userName, string password)
        {
            UserDto userDto = UserBll.GetUser(userName, password);
            if (userDto == null)
            {
                return "InValid";
            }
            else
            {
                return "Valid";
            }
        }

        // POST: api/Login
        public void Post([FromBody]string value)
        {
            //string userName = Request.Form["UserName"]; 
            //string password = Request.Form["Password"];
            
        }

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
