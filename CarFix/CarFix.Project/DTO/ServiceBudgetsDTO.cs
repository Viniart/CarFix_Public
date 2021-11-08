using CarFix.Project.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.DTO
{
    public class ServiceBudgetsDTO : Entity
    {
        // Cuidado com a entity criand Ids iguais para o budget e o serviço
        public Guid IdServiceType { get; set; }
        public Guid IdVehicle { get; set; }
        public string? ServiceDescription { get; set; }
    }
}
