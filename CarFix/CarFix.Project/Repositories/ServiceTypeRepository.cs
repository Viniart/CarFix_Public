using CarFix.Project.Domains;
using CarFix.Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Repositories
{
    public class ServiceTypeRepository : IServiceTypeRepository
    {
        public void Delete(Guid idServiceType)
        {
            throw new NotImplementedException();
        }

        public ServiceType FindServiceType(Guid idType)
        {
            throw new NotImplementedException();
        }

        public List<ServiceType> ListAllTypes()
        {
            throw new NotImplementedException();
        }

        public void Register(ServiceType newType)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid idServiceType, ServiceType updatedType)
        {
            throw new NotImplementedException();
        }
    }
}
