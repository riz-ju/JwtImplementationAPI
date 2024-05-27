using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetPublic() {
            return Ok("Hye this the public data and can be accessed ");
        }

        [HttpGet("private")]
        [Authorize(Roles ="Seller")]
        public ActionResult GetPrivate() {
            return Ok("Hye this the private data and can be accessed after authentication only");
        }

    }
}
