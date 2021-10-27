using CarFix.Project.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Interfaces
{
    interface IServiceImageRepository
    {
        List<ServiceImage> ListAllImages();
        ServiceImage FindServiceImage(int idServiceImage);
        void Register(ServiceImage newServiceImage);
        void Update(Guid idServiceImage, ServiceImage updatedServiceImage);
        void Delete(Guid idServiceImage);
    }
}
