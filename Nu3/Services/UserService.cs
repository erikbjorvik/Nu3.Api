using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Nu3.Models;
using Nu3.Services.Interfaces;

namespace Nu3.Services
{
    public class UserService : IUserService
    {

        public IEnumerable<User> GetUsersByBeaconId(string id)
        {
            throw new NotImplementedException();
        }

        public void AddUser(User user)
        {
            
            if (user == null)
            {
                throw new ArgumentNullException("User cannot be null");
            }

            if (string.IsNullOrWhiteSpace(user.Firstname))
            {
                throw new ArgumentException("Firstname not valid");
            }

            if (string.IsNullOrWhiteSpace(user.Lastname))
            {
                throw new ArgumentException("Lastname not valid");
            }

            if (string.IsNullOrWhiteSpace(user.SocialSecurityNumber))
            {
                throw new ArgumentException("SocialSecurityNumber not valid");
            }



        }

        public User GetUserById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
