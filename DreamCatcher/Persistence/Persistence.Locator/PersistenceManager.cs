using Persistence;
using Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Locator
{
    public static class PersistenceManager
    {
        public static IUserDao GetUserDao()
        {
            return UserDao.Instance;
        }
    }
}
