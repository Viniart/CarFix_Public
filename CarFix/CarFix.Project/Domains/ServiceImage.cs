using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Domains
{
    public class ServiceImage : Entity
    {
        public ServiceImage(string imagePath, Guid idService)
        {
            ImagePath = imagePath;
            IdService = idService;
        }

        public string ImagePath { get; private set; }

        // Composition
        public Guid IdService { get; private set; }
        public virtual Service Service { get; private set; }


    }
}
