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
    [Route("api/User")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UnitOfWork.UnitOfWork _unitOfWork;
        private readonly CarFixContext _context;


        public UsersController(CarFixContext context)
        {
            _context = context;
            _unitOfWork = new UnitOfWork.UnitOfWork(_context);

        }


        [HttpGet]
        public IActionResult GetAllUsers()
        {

            try
            {

                return Ok(_unitOfWork.UserRepository.ListAllUsers());

            }

            catch (Exception error)
            {

                return BadRequest(error);

            }

        }


        [HttpGet("{id}")]
        public IActionResult FindUserById(Guid id)
        {
            try
            {

                return Ok(_unitOfWork.UserRepository.FindUser(id));


            }

            catch (Exception error)
            {

                return BadRequest(error);

            }

        }

        [HttpPost]
        public IActionResult RegisterUser(User newUser)
        {
            try
            {

                _unitOfWork.UserRepository.Register(newUser);

                return StatusCode(201);

            }
            catch (Exception error)
            {

                return BadRequest(error);

            }

        }


        [HttpPut]
        public IActionResult UpdateUser(User userUpdated)
        {
            try
            {

                _unitOfWork.UserRepository.Update(userUpdated);

                return StatusCode(204);

            }

            catch (Exception error)
            {
                return BadRequest(error);
            }

        }


        [HttpDelete]
        public IActionResult DeleteUser(Guid id)
        {
            try
            {
                _unitOfWork.UserRepository.Delete(id);

                return StatusCode(204);
            }

            catch (Exception error)
            {

                return BadRequest(error);

            }

        }

    }
}
