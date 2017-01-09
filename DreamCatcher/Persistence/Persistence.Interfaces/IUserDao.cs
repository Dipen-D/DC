using Business.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Interfaces
{
    public interface IUserDao
    {
        UserDto GetUser(string userName, string password);

        void RegisterUser(RegisterUserDto data);
    }
}
