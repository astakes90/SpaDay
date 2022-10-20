using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using SpaDay.Models;

namespace SpaDay.Data
{
    public class UserData
    {
        static private List<User> Users = new List<User>();

        // Add
        public static void Add(User newUser)
        {
            Users.Add(newUser);
        }

        // GetById
        public static User Get(int index)
        {
            return Users[index];
        }
    }
}
