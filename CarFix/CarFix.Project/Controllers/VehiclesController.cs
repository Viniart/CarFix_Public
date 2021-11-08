using CarFix.Project.Contexts;
using CarFix.Project.Domains;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly UnitOfWork.UnitOfWork _unitOfWork;
        private readonly CarFixContext _context;

        public VehiclesController(CarFixContext context)
        {
            _context = context;
            _unitOfWork = new UnitOfWork.UnitOfWork(_context);
        }

        [HttpGet]
        public IActionResult GetAllVehicles()
        {

            try
            {

                return Ok(_unitOfWork.VehicleRepository.ListAllVehicles());

            }

            catch (Exception error)
            {
                return BadRequest(error);
            }

        }


        [HttpGet("{id}")]
        public IActionResult GetVehicleById(Guid id)
        {
            try
            {

                return Ok(_unitOfWork.VehicleRepository.FindVehicle(id));

            }


            catch (Exception error)
            {

                return BadRequest(error);

            }

        }

        [Route("/plate")]
        [HttpGet]
        public IActionResult GetVehicleByLicensePlate(string licensePlate)
        {

            try
            {

                return Ok(_unitOfWork.VehicleRepository.FindVehiclePerLicensePlate(licensePlate));

            }
            catch (Exception error)
            {

                return BadRequest(error);

            }

        }


        [HttpPut]
        public IActionResult UpdateVehicle(Vehicle vehicleUpdated)
        {

            try
            {

                _unitOfWork.VehicleRepository.Update(vehicleUpdated);

                return StatusCode(204);

            }

            catch (Exception error)
            {

                return BadRequest(error);

            }
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteVehicle(Guid id)
        {

            try
            {
                _unitOfWork.VehicleRepository.Delete(id);

                return StatusCode(204);
            }

            catch (Exception error)
            {
                return BadRequest(error);
            }

        }


        [HttpPost]
        public IActionResult RegisterVehicle(Vehicle newVehicle)
        {

            try
            {

                _unitOfWork.VehicleRepository.Register(newVehicle);

                return StatusCode(201);

            }

            catch (Exception error)
            {
                return BadRequest(error);
            }
        }
    }
}
