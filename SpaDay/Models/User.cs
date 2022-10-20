using System;
namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateOfRegistration { get; set; }

        public User()
        {
            DateOfRegistration = DateTime.UtcNow;
        }

        public User(string u, string e, string p) : this()
        {
            Username = u;
            Email = e;
            Password = p;
        }
    }
}

