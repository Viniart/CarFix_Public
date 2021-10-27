using CarFix.Project.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Interfaces
{
    public interface IVehicleRepository
    {
        List<Vehicle> ListAllVehicles();
        List<Vehicle> ListVehiclesPerLicensePlate(string licensePlate);
        Vehicle FindVehicle(Guid idVehicle);
        void Register(Vehicle newVehicle);
        void Update(Guid idUser, Vehicle updatedVehicle);
        void Delete(Guid idUser);
    }
}
