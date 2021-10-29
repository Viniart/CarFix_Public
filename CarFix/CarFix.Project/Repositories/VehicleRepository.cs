using CarFix.Project.Domains;
using CarFix.Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        public void Delete(Guid idUser)
        {
            throw new NotImplementedException();
        }

        public Vehicle FindVehicle(Guid idVehicle)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> ListAllVehicles()
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> ListVehiclesPerLicensePlate(string licensePlate)
        {
            throw new NotImplementedException();
        }

        public void Register(Vehicle newVehicle)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid idUser, Vehicle updatedVehicle)
        {
            throw new NotImplementedException();
        }
    }
}
