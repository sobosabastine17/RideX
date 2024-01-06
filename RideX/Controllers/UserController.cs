using Microsoft.AspNetCore.Mvc;

namespace RideX.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpGet]
    public string name(){
        return "Sabas";
    }
}
