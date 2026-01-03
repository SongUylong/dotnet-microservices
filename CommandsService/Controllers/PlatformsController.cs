using Microsoft.AspNetCore.Mvc;

namespace CommandsServices.Controllers
{
  [Route("api/c/[controller]")]
  [ApiController]
  public class PlatformsController : ControllerBase
  {
    public PlatformsController() {}

    [HttpPost]
    public ActionResult TestInboundConnection()
    {
      Console.Write("--> Inbound Post # commend service");
      return Ok("InBound Test of from the Platfrom Controller ");
    }
  }
}
