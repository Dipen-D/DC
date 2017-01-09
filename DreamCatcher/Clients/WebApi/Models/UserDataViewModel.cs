using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    // Models returned by AccountController actions.

    public class UserDataViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Pin { get; set; }
    }
}
