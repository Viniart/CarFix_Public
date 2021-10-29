using CarFix.Project.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Domains
{
    public class Service : Entity
    {
        public Service(string serviceDescription, double price, string observations, EnServiceStatus serviceStatus, Guid idUser ,Guid idServiceType, Guid idBudget)
        {
            ServiceDescription = serviceDescription;
            Price = price;
            Observations = observations;
            IdUser = idUser;
            IdServiceType = idServiceType;
            IdBudget = idBudget;
            ServiceStatus = serviceStatus;
        }

        public string ServiceDescription { get; private set; }
        public double Price { get; private set; }
        public string Observations { get; private set; }
        public EnServiceStatus ServiceStatus { get; private set; }

        // Compositions
        public Guid IdUser { get; private set; }
        public virtual User Worker { get; private set; }
        
        public Guid IdServiceType { get; private set; }
        public virtual ServiceType ServiceType { get; private set; }

        public Guid IdBudget { get; private set; }
        public virtual Budget Budget { get; private set; }

        public ICollection<ServiceImage> ServiceImages { get; private set; }
    }
}
