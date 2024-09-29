using Microsoft.AspNetCore.Mvc;

namespace HelloWorldAPI.Controllers
{
  [ApiController]
  //[Route("api/[controller]")]
  [Route("v1/greetings")]
  [Route("v2/Banana")]
  [Route("v3/cocacola")]
  public class HelloWorldController : ControllerBase
  {
    [HttpGet]
    public IActionResult Get()
    {
      return Ok("Hello World, from ASP.NET Core");
    }
  }
}