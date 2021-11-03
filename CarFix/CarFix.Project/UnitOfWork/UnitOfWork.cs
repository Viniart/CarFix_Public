using CarFix.Project.Contexts;
using CarFix.Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.UnitOfWork
{
    public class UnitOfWork
    {
        private readonly CarFixContext c_Context;

        private UserRepository _userRepository;
        private VehicleRepository _vehicleRepository;

        public UnitOfWork(CarFixContext _context)
        {
            c_Context = _context;
        }

        public void Save()
        {
            c_Context.SaveChanges();
        }

        public UserRepository UserRepository
        {
            get
            {
                if(_userRepository == null)
                {
                    _userRepository = new UserRepository(c_Context);
                }
                return _userRepository;
            }
        }

        public VehicleRepository VehicleRepository
        {
            get
            {
                if(_vehicleRepository == null)
                {
                    _vehicleRepository = new VehicleRepository(c_Context);
                }
                return _vehicleRepository;
            }
        }
    }
}
