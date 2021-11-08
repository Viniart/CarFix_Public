using CarFix.Project.Domains;
using CarFix.Project.DTO;
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
        void RegisterService(ServiceBudgetsDTO newService);
        void Update(Service updatedService);
        void Delete(Guid idService);
    }
}
