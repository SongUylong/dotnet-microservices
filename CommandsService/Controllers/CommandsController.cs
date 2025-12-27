using Microsoft.AspNetCore.Mvc;

namespace CommandsServices.Controllers
{

  [Route("api/c/[controller]")]
  [ApiController]
  public class CommandsController : ControllerBase
  {
    [HttpPost]
    public IActionResult TestInboundConnection()
    {
      Console.WriteLine("--> Getting platforms");

      return Ok("--> InBound Tested");
    }
  }
}
