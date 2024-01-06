using Microsoft.AspNetCore.Mvc;
using RideX.Services;

namespace RideX.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService service;
    public UserController(IUserService service){
        this.service=service;
    }
    [HttpGet]
    public string name(){
        return "Sabas";
    }
    [HttpGet]
    public IActionResult GetAll(){
        var data= this.service.GetUsers();
        if(data==null){
            return NotFound();
        }
        return Ok(data);
    }
}
