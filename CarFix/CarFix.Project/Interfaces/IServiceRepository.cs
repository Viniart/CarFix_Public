using CarFix.Project.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Interfaces
{
    interface IServiceRepository
    {
        List<Service> ListAllServices();
        Service? FindService(Guid idService);
        void AnswerService(Guid idService, double price, string observations);
        void RegisterService(Service newService);
        void Update(Service updatedService);
        void Delete(Guid idService);
    }
}
