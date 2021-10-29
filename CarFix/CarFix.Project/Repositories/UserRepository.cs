using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarFix.Project.Contexts;
using CarFix.Project.Domains;
using CarFix.Project.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarFix.Project.Repositories
{
    public class UserRepository : IUserRepository
    {
        private CarFixContext c_Context = null;
        DbSet<User> c_DbSet;
        public void Delete(Guid idUser)
        {
            throw new NotImplementedException();
        }

        public User FindUser(Guid idUser)
        {
            throw new NotImplementedException();
        }

        public List<User> ListAllUsers()
        {
            throw new NotImplementedException();
        }

        public void Register(User newUser)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid idUser, User updatedUser)
        {
            throw new NotImplementedException();
        }
    }
}
