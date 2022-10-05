using Microsoft.AspNetCore.Mvc;
using Financial_ms.Services;
using Financial_ms.Models;

namespace Financial_ms.Controllers
{
    [Route("financialms/")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        //GET 
        [Route("connection")]
        [HttpGet]
        public ActionResult IsConnected()
        {
            return Ok($"Connection to a microservice done");
        }

        //GET
  /*      [Route("user/{id}")]
        [HttpGet]
        public ActionResult<User> Get(string id)
        {
            var user = userService.Get(id);

            if (user == null)
            {
                return NotFound($"User with id = {id} not found");
            }
            return user;
        }

        //POST
        [Route("user/")]
        [HttpPost]
        public ActionResult<User> Post( [FromBody]User user)
        {          
            userService.Create(user);            
            //return CreatedAtAction(nameof(Get),  new { id = user.Id }, user);      
            return CreatedAtAction(nameof(Post), user);      
        }

        //PUT 
        [Route("user/{id}")]
        [HttpPut]
        public ActionResult Put(string id, [FromBody] User user)
        {
            var existingUser = userService.Get(id);

            if (existingUser == null)
            {
                return NotFound($"User with Id: {id} not found");
            }

            userService.Update(id,user);
            return NoContent();
        }

        //DELETE
        [Route("user/{id}")]
        [HttpDelete]
        public ActionResult Delete(string id)
        {
            var existingUser = userService.Get(id);

            if (existingUser == null)
            {
                return NotFound($"User with Id: {id} not found");
            }

            userService.Remove(existingUser.Id);
            return Ok($"User with Id: {id} deleted");
        }*/
    }
}