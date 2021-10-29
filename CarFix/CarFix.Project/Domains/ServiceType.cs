using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Domains
{
    public class ServiceType : Entity
    {
        public ServiceType(string typeName)
        {
            TypeName = typeName;
        }

        public string TypeName { get; private set; }

        public ICollection<Service> Services { get; set; }
    }
}
