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
    public class BudgetsController : ControllerBase
    {
        private readonly UnitOfWork.UnitOfWork _unitOfWork;
        private readonly CarFixContext _context;


        public BudgetsController(CarFixContext context)
        {
            _context = context;
            _unitOfWork = new UnitOfWork.UnitOfWork(_context);

        }

        [HttpGet]
        public IActionResult GetAllBudgets()
        {
            try
            {
                return Ok(_unitOfWork.BudgetRepository.ListAllBudgets());
            }

            catch (Exception error)
            {

                return BadRequest(error);

            }
        }

        [Route("active")]
        [HttpGet]
        public IActionResult GetActiveBudgets()
        {
            try
            {
                return Ok(_unitOfWork.BudgetRepository.ListActiveBudgets());
            }

            catch (Exception error)
            {

                return BadRequest(error);

            }
        }

        //[Route("id")]
        //[HttpGet("{id}")]
        //public IActionResult GetBudgetById(Guid idBudget)
        //{
        //    try
        //    {

        //        return Ok(_unitOfWork.BudgetRepository.FindBudget(idBudget));

        //    }

        //    catch (Exception error)
        //    {

        //        return BadRequest(error);

        //    }
        //}

        [HttpGet("{id}")]
        public IActionResult GetBudgetByVehicleId(Guid idVehicle)
        {
            try
            {

                return Ok(_unitOfWork.BudgetRepository.FindBudgetByVehicle(idVehicle));

            }

            catch (Exception error)
            {

                return BadRequest(error);

            }
        }


        [HttpPut]
        public IActionResult UpdateBudget(Budget updatedBudget)
        {
            try
            {

                _unitOfWork.BudgetRepository.Update(updatedBudget);

                return StatusCode(204);

            }

            catch (Exception error)
            {

                return BadRequest(error);

            }
        }

        [Route("register")]
        [HttpPost]
        public IActionResult RegisterBudget(Budget newBudget)
        {
            try
            {

                _unitOfWork.BudgetRepository.Register(newBudget);

                return StatusCode(201);

            }

            catch (Exception error)
            {

                return BadRequest(error);

            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBudget(Guid idBudget)
        {
            try
            {

                _unitOfWork.BudgetRepository.Delete(idBudget);

                return StatusCode(204);

            }

            catch (Exception error)
            {

                return BadRequest(error);

            }
        }

    }
}
