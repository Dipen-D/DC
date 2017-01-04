using Business.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IUserBll
    {
        UserDto GetUser(string userName, string password);
    }
}
