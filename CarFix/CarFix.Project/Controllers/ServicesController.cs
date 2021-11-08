using CarFix.Project.Contexts;
using CarFix.Project.Domains;
using CarFix.Project.DTO;
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
    public class ServicesController : ControllerBase
    {
        private readonly UnitOfWork.UnitOfWork _unitOfWork;
        private readonly CarFixContext _context;


        public ServicesController(CarFixContext context)
        {
            _context = context;
            _unitOfWork = new UnitOfWork.UnitOfWork(_context);

        }

        [HttpGet("{id}")]
        public IActionResult GetServiceById(Guid id)
        {
            try
            {

                return Ok(_unitOfWork.ServiceRepository.FindService(id));

            }

            catch (Exception error)
            {

                return BadRequest(error);

            }
        }


        [HttpGet]
        public IActionResult GetAllServices()
        {
            try
            {

                return Ok(_unitOfWork.ServiceRepository.ListAllServices());

            }

            catch (Exception error)
            {
                return BadRequest(error);
            }

        }


        [HttpPost]
        public IActionResult RegisterService(ServiceBudgetsDTO newServiceBudget)
        {

            try
            {
                _unitOfWork.ServiceRepository.RegisterService(newServiceBudget);

                return StatusCode(204);

            }

            catch (Exception error)
            {
                return BadRequest(error);
            }

        }


        [HttpPut]
        public IActionResult UpdateService(Service updatedService)
        {
            try
            {

                _unitOfWork.ServiceRepository.Update(updatedService);

                return StatusCode(204);

            }

            catch (Exception error)
            {
                return BadRequest(error);
            }

        }


        [HttpDelete("{id}")]
        public IActionResult DeleteService(Guid id)
        {

            try
            {

                _unitOfWork.ServiceRepository.Delete(id);

                return StatusCode(204);

            }

            catch (Exception error)
            {
                return BadRequest(error);
            }
        }



        [HttpPost]
        public IActionResult AnswerService(Guid idService, double price, string observations)
        {

            try
            {

                _unitOfWork.ServiceRepository.AnswerService(idService, price, observations);

                return StatusCode(201);

            }

            catch (Exception error)
            {
                return BadRequest(error);
            }
        }
    }
}
