using Business.Entities.Dtos;
using SampleApp.EF;
using Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class UserDao : IUserDao
    {
        private static readonly UserDao _Instance = new UserDao();
        private readonly Dc dc;

        private UserDao()
        {
            dc = new Dc();
        }

        public static UserDao Instance
        {
            get { return _Instance; }
        }

        public UserDto GetUser(string userName, string password)
        {
            UserDto userDto = null;
            User user = dc.Users.FirstOrDefault(u => u.UserName == userName && u.Password == password);
            if (user != null)
            {
                userDto = new UserDto();
                userDto.Id = user.Id;
                userDto.UserName = user.UserName;
            }
            return userDto;
        }
        
        public void RegisterUser(RegisterUserDto data)
        {
            User newUser = new User();
            newUser.UserName = data.UserName;
            newUser.Email= data.Email;
            newUser.Password = data.Password;
            newUser.TempRegPIN= data.Pin;
            dc.Users.Add(newUser);
            dc.SaveChanges();
        }


        public UserDto GetUserData(int id)
        {
            UserDto userDto = null;
            User user = dc.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                userDto = new UserDto();
                userDto.Id = user.Id;
                userDto.UserName = user.UserName;
                userDto.Pin = user.TempRegPIN;
                userDto.Email = user.Email;
            }
            return userDto;
        }
    }
}
