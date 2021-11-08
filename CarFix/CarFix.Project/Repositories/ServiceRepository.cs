using CarFix.Project.Contexts;
using CarFix.Project.Domains;
using CarFix.Project.DTO;
using CarFix.Project.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarFix.Project.Repositories
{
    public class ServiceRepository : IServiceRepository
    {

        private readonly CarFixContext c_Context;

        public ServiceRepository(CarFixContext _context)
        {
            c_Context = _context;
        }


        public void AnswerService(Guid idService, double price, string observations)
        {
            
        }

        public void Delete(Guid idService)
        {
            Service selectedService = c_Context.Services.Find(idService);

            c_Context.Services.Remove(selectedService);

            c_Context.SaveChanges();
        }

        public Service? FindService(Guid idService)
        {
            return c_Context.Services.FirstOrDefault(x => x.Id == idService);
        }

        
        public List<Service> ListAllServices()
        {
            return c_Context.Services
                .AsNoTracking()
                .Include(x => x.Worker)
                .Include(x => x.ServiceType)
                .Include(x => x.Budget)
                .Include(x => x.ServiceImages)
                .ToList();
        }

        public void RegisterService(ServiceBudgetsDTO newServiceBudget)
        {
            Service newService = new Service();
            Budget newBudget = new Budget();

            newService.ServiceDescription = newServiceBudget.ServiceDescription;
            newService.IdServiceType = newServiceBudget.IdServiceType;
            newService.IdBudget = newBudget.Id;

            newBudget.IdVehicle = newServiceBudget.IdVehicle;

            c_Context.Services.Add(newService);
            c_Context.Budgets.Add(newBudget);

            c_Context.SaveChanges();
        }

        public void Update(Service updatedService)
        {
            c_Context.Entry(updatedService).State = EntityState.Modified;

            c_Context.SaveChanges();
        }
    
    }

}
