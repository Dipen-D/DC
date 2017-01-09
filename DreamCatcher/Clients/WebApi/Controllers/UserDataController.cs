using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Business.Entities.Dtos;
using Business.Interfaces;
using Business.Locator;
using WebApi.Models;

namespace WebApi.Controllers
{
    //[Authorize]
    public class UserDataController : ApiController
    {
        private IUserBll UserBll = BllManager.GetUserBll();
        // GET: api/UserData/5
        public UserDataViewModel Get(int id)
        {
            UserDto userDto = UserBll.GetUserData(id);
            UserDataViewModel data = null;
            if (userDto != null)
            {
                data = new UserDataViewModel();
                data.UserName = userDto.UserName;
                data.Email = userDto.Email;
                data.Pin = userDto.Pin;
                data.Id = userDto.Id;
            }
            return data;
        }
    }
}
