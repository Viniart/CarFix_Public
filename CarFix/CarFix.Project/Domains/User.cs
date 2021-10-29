using CarFix.Project.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Domains
{
    public class User : Entity
    {
        public User(string username, string email, string password, EnUserType userType, string phoneNumber)
        {
            Username = username;
            Email = email;
            Password = password;
            UserType = userType;
            PhoneNumber = phoneNumber;
        }

        public string Username { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public EnUserType UserType { get; private set; }
        public string PhoneNumber { get; private set; }

        public ICollection<Vehicle> Vehicles { get; private set; }
        public ICollection<Service> Services { get; private set; }
    }
}
