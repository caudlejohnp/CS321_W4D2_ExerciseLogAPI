using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS321_W4D2_ExerciseLogAPI.ApiModels;
using CS321_W4D2_ExerciseLogAPI.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CS321_W4D2_ExerciseLogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IActionResult Get()
        {
            var userModel = _userService.GetAll().ToApiModels();
            return Ok(userModel);
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _userService.Get(id).ToApiModel();
            if (user == null) return NotFound();
            return Ok(user);
        }

        // POST api/<UsersController>
        [HttpPost]
        public IActionResult Post([FromBody] UserModel newUser)
        {
            var user = _userService.Add(newUser.ToDomainModel());
            if (user == null) return BadRequest();
            return CreatedAtAction("Get", new { Id = newUser.Id }, newUser);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserModel updatedUser)
        {
            var user = _userService.Update(updatedUser.ToDomainModel());
            if (user == null) return BadRequest();
            return Ok(user);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _userService.Get(id);
            _userService.Remove(user);
            return NoContent();
        }
    }
}
