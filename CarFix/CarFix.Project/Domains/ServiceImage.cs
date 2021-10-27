using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Domains
{
    public class ServiceImage : Entity
    {
        public ServiceImage(string imagePath, Guid serviceId)
        {
            ImagePath = imagePath;
            IdService = serviceId;
        }

        public string ImagePath { get; private set; }

        // Composition
        public Guid IdService { get; private set; }


    }
}
