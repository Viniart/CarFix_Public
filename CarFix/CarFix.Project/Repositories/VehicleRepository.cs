using CarFix.Project.Contexts;
using CarFix.Project.Domains;
using CarFix.Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarFix.Project.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly CarFixContext c_Context;

        public VehicleRepository(CarFixContext _context)
        {
            c_Context = _context;
        }
        public void Delete(Guid idVehicle)
        {
            Vehicle selectedVehicle = c_Context.Vehicles.Find(idVehicle);

            c_Context.Vehicles.Remove(selectedVehicle);

            c_Context.SaveChanges();
        }

        public Vehicle FindVehicle(Guid idVehicle)
        {
            Vehicle? searchVehicle = c_Context.Vehicles.FirstOrDefault(x => x.Id == idVehicle);

            if(searchVehicle != null)
            {
                return searchVehicle;
            }

            return null;
        }

        public List<Vehicle> ListAllVehicles()
        {
            return c_Context.Vehicles
                .AsNoTracking()
                .Include(x => x.User)
                .ToList();
        }

        public Vehicle FindVehiclePerLicensePlate(string licensePlate)
        {
            return c_Context.Vehicles.FirstOrDefault(x => x.LicensePlate == licensePlate);
        }

        public void Register(Vehicle newVehicle)
        {
            c_Context.Vehicles.Add(newVehicle);
            c_Context.SaveChanges();
        }

        public void Update(Vehicle vehicle)
        {
            c_Context.Entry(vehicle).State = EntityState.Modified;
            c_Context.SaveChanges();
        }
    }
}
