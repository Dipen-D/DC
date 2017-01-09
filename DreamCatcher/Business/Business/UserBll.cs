using Business.Entities.Dtos;
using Business.Interfaces;
using Persistence.Interfaces;
using Persistence.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class UserBll : IUserBll
    {
        private static readonly UserBll _Instance = new UserBll();
        private readonly IUserDao UserDao;

        private UserBll()
        {
            UserDao = PersistenceManager.GetUserDao();
        }

        public static UserBll Instance
        {
            get { return _Instance; }
        }

        public UserDto GetUser(string userName, string password)
        {
            return UserDao.GetUser(userName, password);
        }

        public void RegisterUser(RegisterUserDto data)
        {
            UserDao.RegisterUser(data);
        }

        public UserDto GetUserData(int id)
        {
            return UserDao.GetUserData(id);
        }
    }
}
