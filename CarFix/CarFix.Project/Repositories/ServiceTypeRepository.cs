using CarFix.Project.Contexts;
using CarFix.Project.Domains;
using CarFix.Project.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarFix.Project.Repositories
{
    public class ServiceTypeRepository : IServiceTypeRepository
    {

        private readonly CarFixContext c_Context;

        public ServiceTypeRepository(CarFixContext _context)
        {
            c_Context = _context;
        }

        public void DeleteServiceType(Guid idServiceType)
        {

            ServiceType selectedServiceType = c_Context.ServiceTypes.Find(idServiceType);

            c_Context.ServiceTypes.Remove(selectedServiceType);

            c_Context.SaveChanges();


        }

        public ServiceType FindServiceType(Guid idServiceType)
        {

            return c_Context.ServiceTypes.FirstOrDefault(x => x.Id == idServiceType);

        }

        
        public List<ServiceType> ListAllServiceTypes()
        {

            return c_Context.ServiceTypes
                .AsNoTracking()
                .ToList();

        }

        
        public void RegisterServiceType(ServiceType newServiceType)
        {

            c_Context.ServiceTypes.Add(newServiceType);

            c_Context.SaveChanges();

        }

        
        public void UpdateServiceType(ServiceType updatedServiceType)
        {

            c_Context.Entry(updatedServiceType).State = EntityState.Modified;

            c_Context.SaveChanges();


        }
    
    
    }

}
