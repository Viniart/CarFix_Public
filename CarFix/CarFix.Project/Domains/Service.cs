using CarFix.Project.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Domains
{
    public class Service : Entity
    {
        public Service(string serviceDescription, double price, string observations, EnServiceStatus serviceStatus, Guid serviceTypeId, Guid budgetId)
        {
            ServiceDescription = serviceDescription;
            Price = price;
            Observations = observations;
            IdServiceType = serviceTypeId;
            IdBudget = budgetId;
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
    }
}
