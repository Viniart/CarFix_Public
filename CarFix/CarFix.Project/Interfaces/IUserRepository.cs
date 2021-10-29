using CarFix.Project.Domains;
using CarFix.Project.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Interfaces
{
    public interface IUserRespository
    {
        List<User> ListAllUsers();
        User FindUser(Guid idUser);
        // User FindWorkers(EnUserType userType);
        void Register(User newUser);
        void Update(Guid idUser, User updatedUser);
        void Delete(Guid idUser);
    }
}
