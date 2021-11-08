using CarFix.Project.Contexts;
using CarFix.Project.Domains;
using CarFix.Project.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarFix.Project.Repositories
{
    public class ServiceImageRepository : IServiceImageRepository
    {

        private readonly CarFixContext c_Context;

        public ServiceImageRepository(CarFixContext _context)
        {

            c_Context = _context;

        }

        public void Delete(Guid idServiceImage)
        {
            ServiceImage selectedServiceImage = c_Context.ServiceImages.Find(idServiceImage);

            c_Context.ServiceImages.Remove(selectedServiceImage);

            c_Context.SaveChanges();
        }

        public ServiceImage FindServiceImage(Guid idServiceImage)
        {
           return c_Context.ServiceImages.FirstOrDefault(x => x.Id == idServiceImage);
        }

        public List<ServiceImage> ListAllImages()
        {
            return c_Context.ServiceImages
                .AsNoTracking()
                .Include(x => x.Service)
                .ToList();
        }

        public void Register(ServiceImage newServiceImage)
        {
            c_Context.ServiceImages.Add(newServiceImage);

            c_Context.SaveChanges();
        }

        public void Update(Guid idServiceImage, ServiceImage updatedServiceImage)
        {

            c_Context.Entry(updatedServiceImage).State = EntityState.Modified;

            c_Context.SaveChanges();

        }
    
    }

}
