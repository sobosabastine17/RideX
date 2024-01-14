using Azure.Identity;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RideX.Services;
using System.Linq;


namespace RideX.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService service;
        private readonly ApiDbContext apiDbContext;

        public UserController(IUserService service, ApiDbContext apiDbContext)
        {
            this.service = service;
            this.apiDbContext = apiDbContext;
        }
        //Get all users
        [HttpGet(Name ="GetAllUser")]
        public async Task<IActionResult>Get(){
            var user = new User(){
              Username = "exampleUsername",
              Email = "example@email.com",
              Password = "examplePassword",
              PhoneNumber = "1234567890"

            };
            apiDbContext.Add(user);
            await apiDbContext.SaveChangesAsync();
            var allUsers = await apiDbContext.Users.ToListAsync();
            return Ok(allUsers);
        }
        // Get a specific user by its id
        [HttpGet("GetAllUsers2")]
        public List<User>Get2(){
            var user = service.GetAllUsers();
            return user;
        }

        [HttpGet("name")]
        public string GetName()
        {
            return "Sabas";
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var data = this.service.GetUsers();
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }
    }
}
