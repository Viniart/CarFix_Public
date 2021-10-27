using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Domains
{
    public class Vehicle : Entity
    {
        public Vehicle(string licensePlate, string modelName, string brandName, int year, string color, string vehicleImage, Guid userId)
        {
            LicensePlate = licensePlate;
            ModelName = modelName;
            BrandName = brandName;
            Year = year;
            Color = color;
            VehicleImage = vehicleImage;
            IdUser = userId;
        }

        public string LicensePlate { get; private set; }
        public string ModelName { get; private set; }
        public string BrandName { get; private set; }
        public int Year { get; private set; }
        public string Color { get; private set; }
        public string VehicleImage { get; private set; }

        // Compositions
        public Guid IdUser { get; private set; }
        public virtual User User { get; private set; }
    }
}
