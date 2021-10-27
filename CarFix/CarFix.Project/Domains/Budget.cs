using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Domains
{
    public class Budget : Entity
    {
        public Budget(double totalValue, DateTime timeEstimate, DateTime visitDate, DateTime finalizationDate, Guid vehicleId)
        {
            TotalValue = totalValue;
            TimeEstimate = timeEstimate;
            VisitDate = visitDate;
            FinalizationDate = finalizationDate;
            IdVehicle = vehicleId;
        }

        public double TotalValue { get; private set; }
        public DateTime TimeEstimate { get; private set; }
        public DateTime VisitDate { get; private set;  }
        public DateTime FinalizationDate { get; private set;  }

        // Compositions
        public Guid IdVehicle { get; private set; }
        public virtual Vehicle Vehicle { get; private set; }
    }
}
