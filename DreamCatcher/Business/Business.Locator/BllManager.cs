using Business;
using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Locator
{
    public static class BllManager
    {
        public static IUserBll GetUserBll()
        {
            return UserBll.Instance;
        }
    }
}
