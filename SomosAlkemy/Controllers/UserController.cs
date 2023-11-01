using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SomosAlkemy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok("Hola"); // aca  con el return tendria que ir un .json con info a utilizar
        }

    }
}
