using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateZombieSchoolSuvival
{
    internal class SignUp
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public SignUp(string  username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }

       
    }
}
