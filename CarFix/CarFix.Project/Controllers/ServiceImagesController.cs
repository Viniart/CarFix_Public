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
    public class ServiceImagesController : ControllerBase
    {
        private readonly UnitOfWork.UnitOfWork _unitOfWork;
        private readonly CarFixContext _context;

        public ServiceImagesController(CarFixContext context)
        {
            _context = context;
            _unitOfWork = new UnitOfWork.UnitOfWork(_context);
        }

        [HttpGet("{id}")]
        public IActionResult GetServiceImageById(Guid id)
        {
            try
            {

                return Ok(_unitOfWork.ServiceImageRepository.FindServiceImage(id));

            }

            catch (Exception error)
            {

                return BadRequest(error);

            }
        }


        [HttpGet]
        public IActionResult GetAllServiceImages()
        {
            try
            {

                return Ok(_unitOfWork.ServiceImageRepository.ListAllImages());

            }

            catch (Exception error)
            {
                return BadRequest(error);
            }

        }


        [HttpPost]
        public IActionResult RegisterServiceImage(ServiceImage newServiceImage)
        {

            try
            {

                _unitOfWork.ServiceImageRepository.Register(newServiceImage);

                return StatusCode(204);

            }

            catch (Exception error)
            {
                return BadRequest(error);
            }

        }


        [HttpPut]
        public IActionResult UpdateServiceImage(ServiceImage updatedServiceImage)
        {
            try
            {

                _unitOfWork.ServiceImageRepository.Update(updatedServiceImage);

                return StatusCode(204);

            }

            catch (Exception error)
            {
                return BadRequest(error);
            }

        }


        [HttpDelete("{id}")]
        public IActionResult DeleteServiceImage(Guid id)
        {

            try
            {

                _unitOfWork.ServiceImageRepository.Delete(id);

                return StatusCode(204);

            }

            catch (Exception error)
            {
                return BadRequest(error);
            }
        }
    }
}
